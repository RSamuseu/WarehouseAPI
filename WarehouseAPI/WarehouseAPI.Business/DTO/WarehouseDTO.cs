namespace WarehouseAPI.Business
{
    public class WarehouseDTO
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public LocationDTO Location { get; set; }

        public CarDTO Cars { get; set; }
    }
}
