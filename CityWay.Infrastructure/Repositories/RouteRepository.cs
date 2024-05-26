using CityWay.Domain.Entities;
using CityWay.Domain.Interfaces;
using CityWay.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq.Expressions;

namespace CityWay.Infrastructure.Repositories
{
    internal sealed class RouteRepository : IRouteRepository
    {
        private readonly CityWayContext _context;

        public RouteRepository(CityWayContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Route>> GetAllAsync()
        {
            return await _context.Routes
                .Include(x => x.Stops)
                .Include(x => x.Points)
                .ToListAsync();
        }

        public async Task<Route> GetByIdAsync(Guid id, params Expression<Func<Route, object>>[] includes)
        {
            IQueryable<Route> query = _context.Set<Route>();

            if (!includes.IsNullOrEmpty())
            {
                foreach (var include in includes) query = query.Include(include);
            }

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            var entity = await _context.Routes.FindAsync(id);

            return entity != null;
        }
    }
}