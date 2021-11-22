using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using WarehouseAPI.DataAccess.Configure.DbSettings;
using WarehouseAPI.DataAccess.Initializer;
using WarehouseAPI.DataAccess.Interfaces;
using WarehouseAPI.DataAcess.Entities;

namespace WarehouseAPI.DataAccess.Repositories
{
    public class CarShopRepository : IRepository<Warehouse>
    {
        private readonly IMongoCollection<Warehouse> _cars;

        public CarShopRepository(IDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _cars = database.GetCollection<Warehouse>("Warehouse");
            var t = DataInitializer.DataList();
            _cars.InsertManyAsync(t);
        }

        public async Task<List<Warehouse>> GetAll()
        {
            var tt = await _cars.Find(car => true).ToListAsync();
            return await _cars.Find(car => true).ToListAsync();
        }
    }
}
