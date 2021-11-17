using Microsoft.EntityFrameworkCore;
using WarehouseAPI.DataAcess.Entities;

namespace WarehouseAPI.DataAcess.Context
{
    public class ApplicatioDBContext : DbContext
    {
        public ApplicatioDBContext(DbContextOptions options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Warehouse>().HasData(
                new Warehouse[]
                {
                new Warehouse { Id = 1, Name = "Warehouse A"},
                new Warehouse { Id = 2, Name = "Warehouse B"},
                new Warehouse { Id = 3, Name = "Warehouse C"},
                new Warehouse { Id = 4, Name = "Warehouse D"}
                });
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseLocation> WarehouseLocations { get; set; }
    }
}
