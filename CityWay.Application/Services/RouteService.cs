using CityWay.Application.Exceptions.Route;
using CityWay.Application.Interfaces;
using CityWay.Domain.Entities;
using CityWay.Domain.Interfaces;

namespace CityWay.Application.Services
{
    internal sealed class RouteService : IRouteService
    {
        private readonly IRouteRepository _routeRepository;

        public RouteService(IRouteRepository routeRepository)
        {
            _routeRepository = routeRepository;
        }

        public async Task<IEnumerable<Route>> GetAllAsync() =>
            await _routeRepository.GetAllAsync();

        public async Task<Route> GetAsync(Guid id)
        {
            if (!await _routeRepository.ExistsAsync(id)) throw new RouteNotFoundException("Given route does not exist");

            return await _routeRepository.GetByIdAsync(id, x => x.Stops, x => x.Points);
        }
    }
}
