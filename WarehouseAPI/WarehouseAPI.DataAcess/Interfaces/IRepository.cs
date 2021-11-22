using System.Collections.Generic;
using System.Threading.Tasks;

namespace WarehouseAPI.DataAccess.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();
    }
}
