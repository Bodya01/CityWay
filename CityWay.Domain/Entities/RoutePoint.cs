﻿#nullable disable

using CityWay.Domain.Enums;

namespace CityWay.Domain.Entities
{
    public class RoutePoint
    {
        public Guid Id { get; set; }

        //
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public PointDirections Direction { get; set; }
        public int Order { get; set; }

        //
        public Guid RouteId { get; set; }
        public Route Route { get; set; }
    }
}