using CityWay.Domain.Interfaces;
using CityWay.Infrastructure.Context;
using CityWay.Infrastructure.Helpers;
using CityWay.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CityWay.Infrastructure
{
    public static class Dependencies
    {
        public static IServiceCollection RegisterContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CityWayContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CityWay"));
            });

            return services;
        }

        public static IServiceCollection MigrateDatabase(this IServiceCollection services)
        {
            var provider = services.BuildServiceProvider();
            var context = provider.GetRequiredService<CityWayContext>();
            context.Database.Migrate();
            context.Database.EnsureCreated();
            DataSeeder.SeedData(context);

            return services;
        }

        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRouteRepository, RouteRepository>();

            return services;
        }
    }
}
