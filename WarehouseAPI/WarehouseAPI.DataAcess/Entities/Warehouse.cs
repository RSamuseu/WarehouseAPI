using MongoDB.Bson.Serialization.Attributes;
using WarehouseAPI.DataAccess.Entities;

namespace WarehouseAPI.DataAcess.Entities
{
    [BsonIgnoreExtraElements]

    public class Warehouse : BaseEntity
    {
        public string Name { get; set; }

        public WarehouseLocation Location { get; set; }

        public Car Cars { get; set; }
    }
}
