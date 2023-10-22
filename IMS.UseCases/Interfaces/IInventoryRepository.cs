using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Interfaces
{
    public interface IInventoryRepository
    {
        Task Add(Inventory inventory);
        Task Edit(Inventory inventory);
        Task<Inventory> GetInventoryByIdAsync(int id);
        Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name);
    }
}
