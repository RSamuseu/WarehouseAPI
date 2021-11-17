using System;
using WarehouseAPI.DataAccess.Entities;

namespace WarehouseAPI.DataAcess.Entities
{
    public class Vehicle : BaseEntity
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public DateTime YearModel { get; set; }

        public decimal Price { get; set; }

        public bool Licensed { get; set; }

        public DateTime Date_Added { get; set; }

        public long? CarId { get; set; }

        public virtual Car Car { get; set; }
    }
}
