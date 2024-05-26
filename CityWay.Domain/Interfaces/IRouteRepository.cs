using CityWay.Domain.Entities;
using System.Linq.Expressions;

namespace CityWay.Domain.Interfaces
{
    public interface IRouteRepository
    {
        Task<IEnumerable<Route>> GetAllAsync();
        Task<Route> GetByIdAsync(Guid id, params Expression<Func<Route, object>>[] includes);
        Task<bool> ExistsAsync(Guid id);
    }
}
