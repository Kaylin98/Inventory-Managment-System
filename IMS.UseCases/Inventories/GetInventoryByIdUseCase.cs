using IMS.CoreBusiness;
using IMS.UseCases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories
{
    public class GetInventoryByIdUseCase : IGetInventoryByIdUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public GetInventoryByIdUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task<Inventory> ExecuteAsync(int id)
        {
            return await inventoryRepository.GetInventoryByIdAsync(id);
        }
    }
}
