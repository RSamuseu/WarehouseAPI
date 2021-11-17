using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseAPI.DataAcess.Entities
{
    public class WarehouseLocation
    {
        [Key]
        [ForeignKey("Warehouse")]
        public long WarehouseLocationId { get; set; }

        public double Lat { get; set; }

        public double Long { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
