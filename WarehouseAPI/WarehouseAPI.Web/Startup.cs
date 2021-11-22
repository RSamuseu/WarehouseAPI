using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WarehouseAPI.DataAccess.Initializer;
using AutoMapper;
using WarehouseAPI.Business;
using WarehouseAPI.Web.Configure;
using WarehouseAPI.Web.AutoMapper;
using WarehouseAPI.DataAccess.Configure.DbSettings;
using WarehouseAPI.DataAcess.Configure.Dependencies;

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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
