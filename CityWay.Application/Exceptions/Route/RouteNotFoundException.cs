namespace CityWay.Application.Exceptions.Route
{
    public sealed class RouteNotFoundException : Exception
    {
        public RouteNotFoundException(string message) : base(message) { }
    }
}
