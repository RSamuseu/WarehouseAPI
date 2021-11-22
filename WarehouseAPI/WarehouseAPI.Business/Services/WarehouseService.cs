using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using WarehouseAPI.Business.Interfaces;
using WarehouseAPI.DataAccess.Interfaces;
using WarehouseAPI.DataAcess.Entities;

namespace WarehouseAPI.Business
{
    public class WarehouseService : IWarehouseService
    {
        private readonly IRepository<Warehouse> _repository;
        private readonly IMapper _mapper;

        public WarehouseService(IRepository<Warehouse> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<WarehouseDTO>> GetAllItems()
        {
            var items = await _repository.GetAll();
            items.ForEach(x => x.Cars.Vehicles.Sort((x, y) => x.Date_Added.CompareTo(y.Date_Added)));
            return _mapper.Map<List<WarehouseDTO>>(items);
        }
    }
}
