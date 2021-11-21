using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseAPI.Web.ViewModels
{
    public class WarehouseViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public LocationViewModel Location { get; set; }

        public CarViewModel Cars { get; set; }
    }
}
