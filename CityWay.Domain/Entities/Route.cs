#nullable disable

using CityWay.Domain.Enums;

namespace CityWay.Domain.Entities
{
    public class Route
    {
        public Guid Id { get; set; }

        //
        public string Name { get; set; }
        public RouteTypes Type { get; set; }

        //
        public Guid CityId { get; set; }
        public City City { get; set; }
        public ICollection<Stop> Stops { get; set; }
        public ICollection<RoutePoint> Points { get; set; }
    }
}