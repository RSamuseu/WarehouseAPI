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
        private readonly IMongoCollection<Warehouse> _warehouses;

        public CarShopRepository(IDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _warehouses = database.GetCollection<Warehouse>("Warehouse");

            //Initial database objects from warehouse.json
            var warehouses = DataInitializer.DataList();
            _warehouses.InsertManyAsync(warehouses);
        }

        public async Task<List<Warehouse>> GetAll()
        {
            return await _warehouses.Find(car => true).ToListAsync();
        }
    }
}
