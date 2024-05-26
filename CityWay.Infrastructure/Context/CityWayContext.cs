using CityWay.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityWay.Infrastructure.Context
{
    public sealed class CityWayContext(DbContextOptions<CityWayContext> options) : DbContext(options)
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<RoutePoint> RoutePoints { get; set; }
        public DbSet<Stop> Stops { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
