namespace WarehouseAPI.DataAccess.Configure.DbSettings
{
    public class CarShopDBSettings : IDBSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
