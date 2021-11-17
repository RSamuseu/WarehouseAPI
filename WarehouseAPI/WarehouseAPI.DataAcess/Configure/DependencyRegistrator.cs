using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WarehouseAPI.DataAcess.Context;

namespace WarehouseAPI.DataAcess.Configure
{
    public static class DependencyRegistrator
    {
        public static IServiceCollection AddDataAccessDatabaseComponents(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicatioDBContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DBConnectionString")));

            return services;
        }
    }
}
