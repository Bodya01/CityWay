using CityWay.Application.Interfaces;
using CityWay.Domain.Enums;
using CityWay.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CityWay.WebUI.Controllers
{
    public class RouteController : Controller
    {
        private readonly IRouteService _routeSerivce;

        public RouteController(IRouteService routeService)
        {
            _routeSerivce = routeService;
        }

        public async Task<IActionResult> Index()
        {
            var routes = await _routeSerivce.GetAllAsync();

            var model = new RouteListViewModel
            {
                BusRoutes = routes.Where(x => x.Type == RouteTypes.Bus).ToArray(),
                TramRoutes = routes.Where(x => x.Type == RouteTypes.Tram).ToArray(),
                TrolleybusRoutes = routes.Where(x => x.Type == RouteTypes.Trolleybus).ToArray(),
                RouteTaxiRoutes = routes.Where(x => x.Type == RouteTypes.RouteTaxi).ToArray(),
            };

            return View(model);
        }

        public async Task<IActionResult> Detail(Guid id)
        {
            var route = await _routeSerivce.GetAsync(id);

            return View(route);
        }
    }
}
