using CityWay.Domain.Entities;

namespace CityWay.Application.Interfaces
{
    public interface IRouteService
    {
        Task<IEnumerable<Route>> GetAllAsync();
        Task<Route> GetAsync(Guid id);
    }
}
