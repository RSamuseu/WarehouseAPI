using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WarehouseAPI.DataAccess.Interfaces;
using WarehouseAPI.DataAccess.Repositories;
using WarehouseAPI.DataAcess.Entities;

namespace WarehouseAPI.Business
{
    public static class DependencyRegistrator
    {
        public static IServiceCollection AddRepositoryAccessComponents(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IRepository<Warehouse>, CarShopRepository>();
            return services;
        }
    }
}
