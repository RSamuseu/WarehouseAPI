using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WarehouseAPI.Business.Interfaces;
using WarehouseAPI.Web.ViewModels;

namespace WarehouseAPI.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private readonly IWarehouseService _warehouseService;
        private readonly IMapper _mapper;

        public CarController(IWarehouseService carService, IMapper mapper)
        {
            _warehouseService = carService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var warehouses = await _warehouseService.GetAllItems();
            
            if(warehouses is null)
            {
                return NotFound();
            }

            var response = _mapper.Map<List<WarehouseViewModel>>(warehouses);
            return Ok(response);
        }
    }
}
