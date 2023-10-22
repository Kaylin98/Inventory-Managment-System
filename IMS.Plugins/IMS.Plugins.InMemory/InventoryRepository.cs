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
                new Inventory() {Id = 1, Name = "Bike body", Quantity = 10, Price = 15 },
                new Inventory() {Id = 1, Name = "Bike wheel", Quantity = 20, Price = 20 },
                new Inventory() {Id = 1, Name = "Bike pedals", Quantity = 20, Price = 20 },
            };
        }

        public async Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name)
        {
            if (string.IsNullOrEmpty(name)) return await Task.FromResult(inventories);

            return inventories.Where(x => x.Name.Contains(name,StringComparison.OrdinalIgnoreCase));
        }
    }
}
