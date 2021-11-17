using WarehouseAPI.DataAccess.Entities;

namespace WarehouseAPI.DataAcess.Entities
{
    public class Warehouse : BaseEntity
    {
        public string Name { get; set; }

        public virtual WarehouseLocation WarehouseLocation { get; set; }
    }
}
