using CityWay.Application.Interfaces;
using CityWay.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CityWay.Application
{
    public static class Dependencies
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IRouteService, RouteService>();

            return services;
        }
    }
}
