using IMS.CoreBusiness;
using IMS.UseCases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> inventories;

        public InventoryRepository()
        {
            inventories = new List<Inventory>()
            {
                new Inventory() {Id = 1, Name = "Bike seat", Quantity = 10, Price = 2 },
                new Inventory() {Id = 2, Name = "Bike body", Quantity = 10, Price = 15 },
                new Inventory() {Id = 3, Name = "Bike wheel", Quantity = 20, Price = 20 },
                new Inventory() {Id = 4, Name = "Bike pedals", Quantity = 20, Price = 20 },
            };
        }

        public Task Add(Inventory inventory)
        {
            if (inventories.Any(x => x.Name.Equals(inventory.Name,StringComparison.OrdinalIgnoreCase))) 
                return Task.CompletedTask;

            var maxId = inventories.Max(x => x.Id);
            inventory.Id = maxId + 1;

            inventories.Add(inventory);

            return Task.CompletedTask;
            
        }

        public Task Edit(Inventory inventory)
        {
            if (inventories.Any(x => x.Id != inventory.Id && x.Name.Equals(inventory.Name, StringComparison.OrdinalIgnoreCase)))
                return Task.CompletedTask;

            var inv = inventories.FirstOrDefault(x => x.Id == inventory.Id);

            if (inv != null)
            {
                inv.Name = inventory.Name;
                inv.Price = inventory.Price;
                inv.Quantity = inventory.Quantity;
            }

            return Task.CompletedTask;
        }

        public async Task<Inventory> GetInventoryByIdAsync(int id)
        {
            var inventory = await Task.FromResult(inventories.First(x => x.Id == id));

            var newInv = new Inventory
            {
                Id = inventory.Id,
                Name = inventory.Name,
                Price = inventory.Price,
                Quantity = inventory.Quantity,
            };
            return newInv;
        }

        public async Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name)
        {
            if (string.IsNullOrEmpty(name)) return await Task.FromResult(inventories);

            return inventories.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
