using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseAPI.DataAccess.Configure;
using WarehouseAPI.DataAccess.Interfaces;
using WarehouseAPI.DataAccess.Repositories;
using WarehouseAPI.DataAccess.Entities;
using WarehouseAPI.DataAcess.Entities;
using WarehouseAPI.DataAccess.Initializer;
using WarehouseAPI.DataAcess.Configure;
using AutoMapper;
using WarehouseAPI.Business;
using WarehouseAPI.Web.Configure;
using WarehouseAPI.Web.AutoMapper;

namespace WarehouseAPI.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new DtoModelMappingProfile());
                mc.AddProfile(new ViewModelMappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.Configure<CarShopDBSettings>(
                Configuration.GetSection(nameof(CarShopDBSettings)));
            services.AddDataAccessComponents(Configuration);
            services.AddRepositoryAccessComponents(Configuration);
            services.AddServicesComponents(Configuration);
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var obj = DataInitializer.DataList();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            //     app.UseStaticFiles();
            app.UseRouting();

            //     app.UseAuthorization();
            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //endpoints.MapControllerRoute(name: "default", pattern: "{controller}/{action");

                // endpoints.MapRazorPages();
            });
        }
    }
}
