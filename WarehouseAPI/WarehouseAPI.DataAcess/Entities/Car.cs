using System.Collections.Generic;
using WarehouseAPI.DataAccess.Entities;

namespace WarehouseAPI.DataAcess.Entities
{
    public class Car : BaseEntity
    {
        public string Location { get; set; }

        public virtual List<Vehicle> Vehicles { get; set; }
    }
}
