namespace WarehouseAPI.DataAccess.Configure.DbSettings
{
    public interface IDBSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
