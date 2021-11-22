using System.Collections.Generic;

namespace WarehouseAPI.DataAcess.Entities
{
    public class Car
    {
        public string Location { get; set; }

        public List<Vehicle> Vehicles { get; set; }
    }
}
