using System;
using MongoDB.Bson.Serialization.Attributes;
using WarehouseAPI.DataAccess.Entities;

namespace WarehouseAPI.DataAcess.Entities
{
    [BsonIgnoreExtraElements]
    public class Vehicle : BaseEntity
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year_Model { get; set; }

        public decimal Price { get; set; }

        public bool Licensed { get; set; }

        public DateTime Date_Added { get; set; }
    }
}
