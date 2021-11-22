using Microsoft.Extensions.DependencyInjection;
using WarehouseAPI.Business;
using WarehouseAPI.Business.Interfaces;

namespace WarehouseAPI.Web.Configure
{
    public static class DependencyRegistrator
    {
        public static IServiceCollection AddServicesComponents(this IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            services.AddTransient<IWarehouseService, WarehouseService>();
            return services;
        }
    }
}
