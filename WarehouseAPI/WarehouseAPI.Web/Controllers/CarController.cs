using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseAPI.Business;
using WarehouseAPI.Business.Interfaces;
using WarehouseAPI.Web.ViewModels;

namespace WarehouseAPI.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private readonly IWarehouseService _carService;
        private readonly IMapper _mapper;

        public CarController(IWarehouseService carService, IMapper mapper)
        {
            _carService = carService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var cars = await _carService.GetAllItems();
            
            if(cars is null)
            {
                return NotFound();
            }

            var items = _mapper.Map<List<WarehouseViewModel>>(cars);
            return Ok(items);
        }
    }
}
