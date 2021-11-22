using AutoMapper.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseAPI.Business;

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
