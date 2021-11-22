using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseAPI.Business;
using WarehouseAPI.Web.ViewModels;

namespace WarehouseAPI.Web.AutoMapper
{
    public class ViewModelMappingProfile : Profile
    {
        public ViewModelMappingProfile()
        {
            CreateMap<WarehouseDTO, WarehouseViewModel>();
            CreateMap<LocationDTO, LocationViewModel>();
            CreateMap<CarDTO, CarViewModel>();
            CreateMap<VehicleDTO, VehicleViewModel>();
        }
    }
}
