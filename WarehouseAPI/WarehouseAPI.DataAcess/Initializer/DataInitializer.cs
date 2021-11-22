using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WarehouseAPI.DataAcess.Entities;

namespace WarehouseAPI.DataAccess.Initializer
{
    public static class DataInitializer
    {
        public static List<Warehouse> DataList()
        {
            JArray jsonArray = JArray.Parse(File.ReadAllText("warehouses.json"));
            string output = JsonConvert.SerializeObject(jsonArray);
            List<Warehouse> deserializedProduct = JsonConvert.DeserializeObject<List<Warehouse>>(output);
            return deserializedProduct;
        }
    }
}
