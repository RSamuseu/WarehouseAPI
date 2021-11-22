using AutoMapper;
using WarehouseAPI.DataAcess.Entities;

namespace WarehouseAPI.Business
{
    public class DtoModelMappingProfile : Profile
    {
        public DtoModelMappingProfile()
        {
            CreateMap<Warehouse, WarehouseDTO>()
                .ForMember(
                dest => dest.Id,
                opt => opt.MapFrom(src => src._Id));
            CreateMap<WarehouseLocation, LocationDTO>();
            CreateMap<Car, CarDTO>();
            CreateMap<Vehicle, VehicleDTO>();
        }
    }
}
