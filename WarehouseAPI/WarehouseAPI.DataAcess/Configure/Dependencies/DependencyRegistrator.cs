using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using WarehouseAPI.DataAccess.Configure.DbSettings;

namespace WarehouseAPI.DataAcess.Configure.Dependencies
{
    public static class DependencyRegistrator
    {
        public static IServiceCollection AddDataAccessComponents(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDBSettings>(options =>
                options.GetRequiredService<IOptions<CarShopDBSettings>>().Value);
            return services;
        }
    }
}
