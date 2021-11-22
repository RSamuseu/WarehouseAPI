using System.Collections.Generic;
using System.Threading.Tasks;

namespace WarehouseAPI.Business.Interfaces
{
    public interface IWarehouseService
    {
        Task<List<WarehouseDTO>> GetAllItems();
    }
}
