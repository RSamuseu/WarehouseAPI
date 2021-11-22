using MongoDB.Bson.Serialization.Attributes;

namespace WarehouseAPI.DataAccess.Entities
{
    public class BaseEntity
    {
        [BsonId]
        public string _Id { get; set; }
    }
}
