namespace CityWay.WebUI.ViewModels
{
    public class RouteListViewModel
    {
        public IEnumerable<Domain.Entities.Route> TramRoutes { get; set; }
        public IEnumerable<Domain.Entities.Route> RouteTaxiRoutes { get; set; }
        public IEnumerable<Domain.Entities.Route> BusRoutes { get; set; }
        public IEnumerable<Domain.Entities.Route> TrolleybusRoutes { get; set; }
    }
}
