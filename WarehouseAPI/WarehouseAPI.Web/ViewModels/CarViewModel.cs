using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseAPI.Web.ViewModels
{
    public class CarViewModel
    {
        public string Location { get; set; }

        public List<VehicleViewModel> Vehicles { get; set; }
    }
}
