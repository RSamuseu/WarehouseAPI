using System;

namespace WarehouseAPI.Business
{
    public class VehicleDTO
    {
        public string Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year_Model { get; set; }

        public decimal Price { get; set; }

        public bool Licensed { get; set; }

        public DateTime Date_Added { get; set; }
    }
}
