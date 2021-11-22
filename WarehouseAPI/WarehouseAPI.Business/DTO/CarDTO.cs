using System.Collections.Generic;

namespace WarehouseAPI.Business
{
    public class CarDTO
    {
        public string Location { get; set; }

        public List<VehicleDTO> Vehicles { get; set; }
    }
}


