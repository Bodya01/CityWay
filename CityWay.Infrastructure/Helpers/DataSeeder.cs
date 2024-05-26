using CityWay.Domain.Entities;
using CityWay.Domain.Enums;
using CityWay.Infrastructure.Context;

namespace CityWay.Infrastructure.Helpers
{
    internal static class DataSeeder
    {
        public static void SeedData(CityWayContext context)
        {
            SeedCities(context);
            SeedRoutes(context);
            SeedStops(context);
            SeedPoints(context);
        }

        private static void SeedCities(CityWayContext context)
        {
            if (!context.Cities.Any())
            {
                var cities = new List<City>
                {
                    new City
                    {
                        Name = "Lviv"
                    }
                };

                context.AddRange(cities);
                context.SaveChanges();
            }
        }

        private static void SeedRoutes(CityWayContext context)
        {
            if (!context.Routes.Any())
            {
                //Lviv routes
                var city = context.Cities.First(x => x.Name == "Lviv");

                var routes = new List<Route>
                {
                    new Route
                    {
                        CityId = city.Id,
                        Name = "38",
                        Type = RouteTypes.Trolleybus,
                    }
                };

                context.Routes.AddRange(routes);
                context.SaveChanges();
            }
        }

        private static void SeedStops(CityWayContext context)
        {
            if (!context.Stops.Any())
            {
                #region route 38 stops
                //Stops for route 38
                var route = context.Routes.First(x => x.Name == "38");

                var backwardStops = new List<Stop>
                {
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "пл. Кропивницького",
                        Direction = PointDirections.Backward,
                        Latitude = 49.836953000000001,
                        Longitude = 24.005731000000001,
                        Order = 1
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Привокзальний ринок",
                        Direction = PointDirections.Backward,
                        Latitude = 49.836463999999999,
                        Longitude = 23.999341000000001,
                        Order = 2
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "ТРЦ \"Скриня\"",
                        Direction = PointDirections.Backward,
                        Latitude = 49.835602000000002,
                        Longitude = 23.994720000000001,
                        Order = 3
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Кульпарківська",
                        Direction = PointDirections.Backward,
                        Latitude = 49.833253999999997,
                        Longitude = 23.990691999999999,
                        Order = 4
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Кардіологічний центр",
                        Direction = PointDirections.Backward,
                        Latitude = 49.829996999999999,
                        Longitude = 23.990310000000001,
                        Order = 5
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Антоновича",
                        Direction = PointDirections.Backward,
                        Latitude = 49.826548000000003,
                        Longitude = 23.989773,
                        Order = 6
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Кульпарків",
                        Direction = PointDirections.Backward,
                        Latitude = 49.819352000000002,
                        Longitude = 23.987794999999998,
                        Order = 7
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Скнилівок",
                        Direction = PointDirections.Backward,
                        Latitude = 49.813349000000002,
                        Longitude = 23.984514999999998,
                        Order = 8
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Боткіна",
                        Direction = PointDirections.Backward,
                        Latitude = 49.811157999999999,
                        Longitude = 23.991672000000001,
                        Order = 9
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Універмаг \"Океан\"",
                        Direction = PointDirections.Backward,
                        Latitude = 49.810513,
                        Longitude = 23.998134,
                        Order = 10
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Володимира Великого",
                        Direction = PointDirections.Backward,
                        Latitude = 49.809970999999997,
                        Longitude = 24.004591999999999,
                        Order = 11
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Тролейбусне депо",
                        Direction = PointDirections.Backward,
                        Latitude = 49.80753,
                        Longitude = 24.007344,
                        Order = 12
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Івана Рубчака",
                        Direction = PointDirections.Backward,
                        Latitude = 49.806002999999997,
                        Longitude = 24.012087000000001,
                        Order = 13
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Боднарівка",
                        Direction = PointDirections.Backward,
                        Latitude = 49.805300000000003,
                        Longitude = 24.018253000000001,
                        Order = 14
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Стрийська - вул. Наукова",
                        Direction = PointDirections.Backward,
                        Latitude = 49.801704000000001,
                        Longitude = 24.018635,
                        Order = 15
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Демнянська",
                        Direction = PointDirections.Backward,
                        Latitude = 49.800265000000003,
                        Longitude = 24.030591000000001,
                        Order = 16
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Духовна семінарія",
                        Direction = PointDirections.Backward,
                        Latitude = 49.799804999999999,
                        Longitude = 24.035388000000001,
                        Order = 17
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Чукаріна",
                        Direction = PointDirections.Backward,
                        Latitude = 49.800471000000002,
                        Longitude = 24.040697999999999,
                        Order = 18
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Хуторівка",
                        Direction = PointDirections.Backward,
                        Latitude = 49.801600000000001,
                        Longitude = 24.045522999999999,
                        Order = 19
                    },
                };

                var forwardStops = new List<Stop>
                {
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Хуторівка",
                        Direction = PointDirections.Forward,
                        Latitude = 49.801962000000003,
                        Longitude = 24.045496,
                        Order = 1
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Чукаріна",
                        Direction = PointDirections.Forward,
                        Latitude = 49.800735000000003,
                        Longitude = 24.040087,
                        Order = 2
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Духовна семінарія",
                        Direction = PointDirections.Forward,
                        Latitude = 49.800199999999997,
                        Longitude = 24.035898,
                        Order = 3
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Демнянська",
                        Direction = PointDirections.Forward,
                        Latitude = 49.800649999999997,
                        Longitude = 24.030266999999998,
                        Order = 4
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Стрийська - вул. Наукова",
                        Direction = PointDirections.Forward,
                        Latitude = 49.802591999999997,
                        Longitude = 24.018370999999998,
                        Order = 5
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Боднарівка",
                        Direction = PointDirections.Forward,
                        Latitude = 49.805501999999997,
                        Longitude = 24.017762999999999,
                        Order = 6
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Івана Рубчака",
                        Direction = PointDirections.Forward,
                        Latitude = 49.806175000000003,
                        Longitude = 24.011623,
                        Order = 7
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Тролейбусне депо",
                        Direction = PointDirections.Forward,
                        Latitude = 49.807917000000003,
                        Longitude = 24.007712999999999,
                        Order = 8
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Коледж телекоммунікацій",
                        Direction = PointDirections.Forward,
                        Latitude = 49.809978000000001,
                        Longitude = 24.007373999999999,
                        Order = 9
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Володимира Великого",
                        Direction = PointDirections.Forward,
                        Latitude = 49.810450000000003,
                        Longitude = 24.001256999999999,
                        Order = 10
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Універмаг \"Океан\"",
                        Direction = PointDirections.Forward,
                        Latitude = 49.810881999999999,
                        Longitude = 23.996783000000001,
                        Order = 11
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Курця",
                        Direction = PointDirections.Forward,
                        Latitude = 49.811497000000003,
                        Longitude = 23.990290000000002,
                        Order = 12
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Скнилівок",
                        Direction = PointDirections.Forward,
                        Latitude = 49.813901000000001,
                        Longitude = 23.985240000000001,
                        Order = 13
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Кульпарків",
                        Direction = PointDirections.Forward,
                        Latitude = 49.818542999999998,
                        Longitude = 23.987784999999999,
                        Order = 14
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Кардіологічний центр",
                        Direction = PointDirections.Forward,
                        Latitude = 49.831225000000003,
                        Longitude = 23.990831,
                        Order = 15
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Кульпарківська",
                        Direction = PointDirections.Forward,
                        Latitude = 49.833945999999997,
                        Longitude = 23.990893,
                        Order = 16
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "ТРЦ \"Скриня\"",
                        Direction = PointDirections.Forward,
                        Latitude = 49.835323000000002,
                        Longitude = 23.994918999999999,
                        Order = 17
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Привокзальний ринок",
                        Direction = PointDirections.Forward,
                        Latitude = 49.836125000000003,
                        Longitude = 23.999374,
                        Order = 18
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Тобілевича",
                        Direction = PointDirections.Forward,
                        Latitude = 49.835939000000003,
                        Longitude = 24.003139999999998,
                        Order = 19
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "пл. Кропивницького",
                        Direction = PointDirections.Forward,
                        Latitude = 49.836953000000001,
                        Longitude = 24.005731000000001,
                        Order = 20
                    },
                };

                context.Stops.AddRange(forwardStops);
                context.Stops.AddRange(backwardStops);
                context.SaveChanges();
                #endregion
            }
        }

        private static void SeedPoints(CityWayContext context)
        {
            if (!context.RoutePoints.Any())
            {
                // Route 38 points
                var route = context.Routes.First(x => x.Name == "38");

                #region route 38 forward points
                var forwardPoints = new List<RoutePoint>
                {
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.801938,
                        Latitude = 24.04551,
                        Order = 1
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80184,
                        Latitude = 24.04511,
                        Order = 2
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80172,
                        Latitude = 24.04459,
                        Order = 3
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80164,
                        Latitude = 24.04429,
                        Order = 4
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80145,
                        Latitude = 24.04334,
                        Order = 5
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80133,
                        Latitude = 24.04286,
                        Order = 6
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80124,
                        Latitude = 24.04256,
                        Order = 7
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80114,
                        Latitude = 24.04219,
                        Order = 8
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80102,
                        Latitude = 24.04173,
                        Order = 9
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80098,
                        Latitude = 24.04157,
                        Order = 10
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80077,
                        Latitude = 24.04076,
                        Order = 11
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80075,
                        Latitude = 24.04066,
                        Order = 12
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8007,
                        Latitude = 24.04049,
                        Order = 13
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80067,
                        Latitude = 24.04034,
                        Order = 14
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.800627,
                        Latitude = 24.040143,
                        Order = 15
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.800627,
                        Latitude = 24.040143,
                        Order = 16
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80048,
                        Latitude = 24.03946,
                        Order = 17
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80045,
                        Latitude = 24.03933,
                        Order = 18
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80037,
                        Latitude = 24.03883,
                        Order = 19
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80028,
                        Latitude = 24.03825,
                        Order = 20
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80026,
                        Latitude = 24.03804,
                        Order = 21
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80021,
                        Latitude = 24.03757,
                        Order = 22
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80015,
                        Latitude = 24.03683,
                        Order = 23
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.800118,
                        Latitude = 24.035905,
                        Order = 24
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.800118,
                        Latitude = 24.035905,
                        Order = 25
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80011,
                        Latitude = 24.03568,
                        Order = 26
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80011,
                        Latitude = 24.03566,
                        Order = 27
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80011,
                        Latitude = 24.03515,
                        Order = 28
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80012,
                        Latitude = 24.03469,
                        Order = 29
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80014,
                        Latitude = 24.03424,
                        Order = 30
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80017,
                        Latitude = 24.03372,
                        Order = 31
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80022,
                        Latitude = 24.03328,
                        Order = 32
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8003,
                        Latitude = 24.03262,
                        Order = 33
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80044,
                        Latitude = 24.03138,
                        Order = 34
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80055,
                        Latitude = 24.03038,
                        Order = 35
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.800566,
                        Latitude = 24.030243,
                        Order = 36
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.800566,
                        Latitude = 24.030243,
                        Order = 37
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80085,
                        Latitude = 24.02779,
                        Order = 38
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80113,
                        Latitude = 24.02545,
                        Order = 39
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8012,
                        Latitude = 24.02479,
                        Order = 40
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80127,
                        Latitude = 24.02417,
                        Order = 41
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80135,
                        Latitude = 24.02334,
                        Order = 42
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80137,
                        Latitude = 24.0231,
                        Order = 43
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80142,
                        Latitude = 24.02256,
                        Order = 44
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80158,
                        Latitude = 24.02124,
                        Order = 45
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80165,
                        Latitude = 24.02059,
                        Order = 46
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80166,
                        Latitude = 24.02047,
                        Order = 47
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.801641,
                        Latitude = 24.020297,
                        Order = 48
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80167,
                        Latitude = 24.02012,
                        Order = 49
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.801845,
                        Latitude = 24.018676,
                        Order = 50
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80189,
                        Latitude = 24.01831,
                        Order = 51
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.801914,
                        Latitude = 24.01813,
                        Order = 52
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.802179,
                        Latitude = 24.018026,
                        Order = 53
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80223,
                        Latitude = 24.01804,
                        Order = 54
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80255,
                        Latitude = 24.01812,
                        Order = 55
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.802614,
                        Latitude = 24.018134,
                        Order = 56
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.802614,
                        Latitude = 24.018134,
                        Order = 57
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80304,
                        Latitude = 24.01823,
                        Order = 58
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80324,
                        Latitude = 24.01828,
                        Order = 59
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80438,
                        Latitude = 24.01854,
                        Order = 60
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80448,
                        Latitude = 24.01857,
                        Order = 61
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8046,
                        Latitude = 24.01861,
                        Order = 62
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80478,
                        Latitude = 24.01866,
                        Order = 63
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80496,
                        Latitude = 24.01872,
                        Order = 64
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80513,
                        Latitude = 24.01877,
                        Order = 65
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8053,
                        Latitude = 24.018812,
                        Order = 66
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805363,
                        Latitude = 24.018271,
                        Order = 67
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8054,
                        Latitude = 24.01795,
                        Order = 68
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805423,
                        Latitude = 24.017742,
                        Order = 69
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805423,
                        Latitude = 24.017742,
                        Order = 70
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80559,
                        Latitude = 24.01625,
                        Order = 71
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80565,
                        Latitude = 24.01564,
                        Order = 72
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80581,
                        Latitude = 24.01419,
                        Order = 73
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80583,
                        Latitude = 24.01398,
                        Order = 74
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80585,
                        Latitude = 24.01377,
                        Order = 75
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80594,
                        Latitude = 24.01294,
                        Order = 76
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806036,
                        Latitude = 24.012096,
                        Order = 77
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80606,
                        Latitude = 24.01188,
                        Order = 78
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806092,
                        Latitude = 24.0116,
                        Order = 79
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806092,
                        Latitude = 24.0116,
                        Order = 80
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80612,
                        Latitude = 24.01135,
                        Order = 81
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80619,
                        Latitude = 24.01069,
                        Order = 82
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80621,
                        Latitude = 24.01059,
                        Order = 83
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80631,
                        Latitude = 24.00958,
                        Order = 84
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8064,
                        Latitude = 24.00873,
                        Order = 85
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806558,
                        Latitude = 24.007245,
                        Order = 86
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80683,
                        Latitude = 24.00731,
                        Order = 87
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80695,
                        Latitude = 24.00734,
                        Order = 88
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80706,
                        Latitude = 24.00738,
                        Order = 89
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.807516,
                        Latitude = 24.00749,
                        Order = 90
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8076,
                        Latitude = 24.00751,
                        Order = 91
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.807929,
                        Latitude = 24.007586,
                        Order = 92
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.807929,
                        Latitude = 24.007586,
                        Order = 93
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80799,
                        Latitude = 24.0076,
                        Order = 94
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80818,
                        Latitude = 24.00765,
                        Order = 95
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80844,
                        Latitude = 24.00771,
                        Order = 96
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80913,
                        Latitude = 24.00789,
                        Order = 97
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80938,
                        Latitude = 24.00795,
                        Order = 98
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8096,
                        Latitude = 24.008,
                        Order = 99
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.809779,
                        Latitude = 24.008031,
                        Order = 100
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80987,
                        Latitude = 24.00754,
                        Order = 101
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80989,
                        Latitude = 24.00736,
                        Order = 102
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.809891,
                        Latitude = 24.007354,
                        Order = 103
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.809891,
                        Latitude = 24.007354,
                        Order = 104
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80992,
                        Latitude = 24.00703,
                        Order = 105
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80994,
                        Latitude = 24.00672,
                        Order = 106
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81002,
                        Latitude = 24.00515,
                        Order = 107
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810052,
                        Latitude = 24.004603,
                        Order = 108
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81008,
                        Latitude = 24.00411,
                        Order = 109
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81008,
                        Latitude = 24.00397,
                        Order = 110
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81016,
                        Latitude = 24.00238,
                        Order = 111
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810276,
                        Latitude = 24.001215,
                        Order = 112
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810276,
                        Latitude = 24.001215,
                        Order = 113
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81032,
                        Latitude = 24.00077,
                        Order = 114
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810345,
                        Latitude = 24.000616,
                        Order = 115
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810527,
                        Latitude = 24.000195,
                        Order = 116
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810547,
                        Latitude = 24.000189,
                        Order = 117
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810573,
                        Latitude = 24.000173,
                        Order = 118
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8106,
                        Latitude = 24.000157,
                        Order = 119
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81063,
                        Latitude = 24.00012,
                        Order = 120
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81066,
                        Latitude = 24.00008,
                        Order = 121
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81068,
                        Latitude = 24.00004,
                        Order = 122
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8107,
                        Latitude = 24,
                        Order = 123
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81071,
                        Latitude = 23.99995,
                        Order = 124
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81073,
                        Latitude = 23.9999,
                        Order = 125
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81073,
                        Latitude = 23.99985,
                        Order = 126
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81074,
                        Latitude = 23.9998,
                        Order = 127
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81074,
                        Latitude = 23.99974,
                        Order = 128
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81073,
                        Latitude = 23.99969,
                        Order = 129
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81072,
                        Latitude = 23.99964,
                        Order = 130
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81071,
                        Latitude = 23.99959,
                        Order = 131
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810687,
                        Latitude = 23.999507,
                        Order = 132
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810661,
                        Latitude = 23.999467,
                        Order = 133
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81063,
                        Latitude = 23.999419,
                        Order = 134
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810508,
                        Latitude = 23.998824,
                        Order = 135
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810583,
                        Latitude = 23.998153,
                        Order = 136
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81063,
                        Latitude = 23.99773,
                        Order = 137
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81065,
                        Latitude = 23.99751,
                        Order = 138
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81067,
                        Latitude = 23.9973,
                        Order = 139
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81068,
                        Latitude = 23.99715,
                        Order = 140
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810723,
                        Latitude = 23.996742,
                        Order = 141
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810723,
                        Latitude = 23.996742,
                        Order = 142
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81085,
                        Latitude = 23.99553,
                        Order = 143
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81099,
                        Latitude = 23.99421,
                        Order = 144
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81101,
                        Latitude = 23.99393,
                        Order = 145
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81102,
                        Latitude = 23.99382,
                        Order = 146
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81104,
                        Latitude = 23.99365,
                        Order = 147
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81111,
                        Latitude = 23.99301,
                        Order = 148
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.811243,
                        Latitude = 23.991693,
                        Order = 149
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81125,
                        Latitude = 23.99162,
                        Order = 150
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8113,
                        Latitude = 23.9912,
                        Order = 151
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81131,
                        Latitude = 23.99105,
                        Order = 152
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81134,
                        Latitude = 23.99076,
                        Order = 153
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.811385,
                        Latitude = 23.990265,
                        Order = 154
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.811385,
                        Latitude = 23.990265,
                        Order = 155
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8114,
                        Latitude = 23.9901,
                        Order = 156
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81144,
                        Latitude = 23.98985,
                        Order = 157
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81146,
                        Latitude = 23.98953,
                        Order = 158
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.811495,
                        Latitude = 23.989258,
                        Order = 159
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81152,
                        Latitude = 23.98893,
                        Order = 160
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81156,
                        Latitude = 23.98858,
                        Order = 161
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81167,
                        Latitude = 23.98743,
                        Order = 162
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81171,
                        Latitude = 23.98704,
                        Order = 163
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81181,
                        Latitude = 23.98603,
                        Order = 164
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81182,
                        Latitude = 23.9859,
                        Order = 165
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81186,
                        Latitude = 23.98552,
                        Order = 166
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81189,
                        Latitude = 23.98524,
                        Order = 167
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8119,
                        Latitude = 23.985178,
                        Order = 168
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81194,
                        Latitude = 23.98507,
                        Order = 169
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812,
                        Latitude = 23.98494,
                        Order = 170
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81212,
                        Latitude = 23.98471,
                        Order = 171
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812186,
                        Latitude = 23.984509,
                        Order = 172
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812302,
                        Latitude = 23.984402,
                        Order = 173
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81235,
                        Latitude = 23.98441,
                        Order = 174
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81241,
                        Latitude = 23.9844,
                        Order = 175
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8125,
                        Latitude = 23.98439,
                        Order = 176
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81258,
                        Latitude = 23.9844,
                        Order = 177
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81264,
                        Latitude = 23.98441,
                        Order = 178
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812859,
                        Latitude = 23.984456,
                        Order = 179
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813,
                        Latitude = 23.98458,
                        Order = 180
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8133,
                        Latitude = 23.984739,
                        Order = 181
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81334,
                        Latitude = 23.98476,
                        Order = 182
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81343,
                        Latitude = 23.98481,
                        Order = 183
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81352,
                        Latitude = 23.98486,
                        Order = 184
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813935,
                        Latitude = 23.985093,
                        Order = 185
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813935,
                        Latitude = 23.985093,
                        Order = 186
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81498,
                        Latitude = 23.98568,
                        Order = 187
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81712,
                        Latitude = 23.98688,
                        Order = 188
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81775,
                        Latitude = 23.98723,
                        Order = 189
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81833,
                        Latitude = 23.98756,
                        Order = 190
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.818565,
                        Latitude = 23.987675,
                        Order = 191
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.818565,
                        Latitude = 23.987675,
                        Order = 192
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81874,
                        Latitude = 23.98776,
                        Order = 193
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8189,
                        Latitude = 23.98783,
                        Order = 194
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.819322,
                        Latitude = 23.987986,
                        Order = 195
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81955,
                        Latitude = 23.98807,
                        Order = 196
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81982,
                        Latitude = 23.98815,
                        Order = 197
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82069,
                        Latitude = 23.98844,
                        Order = 198
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82117,
                        Latitude = 23.98859,
                        Order = 199
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82121,
                        Latitude = 23.9886,
                        Order = 200
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.821449,
                        Latitude = 23.988686,
                        Order = 201
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82242,
                        Latitude = 23.98898,
                        Order = 202
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82301,
                        Latitude = 23.98916,
                        Order = 203
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82327,
                        Latitude = 23.98924,
                        Order = 204
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82369,
                        Latitude = 23.98936,
                        Order = 205
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8238,
                        Latitude = 23.98938,
                        Order = 206
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82391,
                        Latitude = 23.98941,
                        Order = 207
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82425,
                        Latitude = 23.9895,
                        Order = 208
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82458,
                        Latitude = 23.98959,
                        Order = 209
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82477,
                        Latitude = 23.98964,
                        Order = 210
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82488,
                        Latitude = 23.98967,
                        Order = 211
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82493,
                        Latitude = 23.98968,
                        Order = 212
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.825395,
                        Latitude = 23.989788,
                        Order = 213
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82586,
                        Latitude = 23.98986,
                        Order = 214
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.826539,
                        Latitude = 23.989945,
                        Order = 215
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82746,
                        Latitude = 23.99006,
                        Order = 216
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.828062,
                        Latitude = 23.990119,
                        Order = 217
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82823,
                        Latitude = 23.99013,
                        Order = 218
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.828824,
                        Latitude = 23.990193,
                        Order = 219
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82902,
                        Latitude = 23.99022,
                        Order = 220
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82956,
                        Latitude = 23.99031,
                        Order = 221
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82997,
                        Latitude = 23.9904,
                        Order = 222
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.829986,
                        Latitude = 23.990404,
                        Order = 223
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83057,
                        Latitude = 23.99056,
                        Order = 224
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83104,
                        Latitude = 23.99069,
                        Order = 225
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83119,
                        Latitude = 23.99072,
                        Order = 226
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.831235,
                        Latitude = 23.990731,
                        Order = 227
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.831235,
                        Latitude = 23.990731,
                        Order = 228
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83131,
                        Latitude = 23.99075,
                        Order = 229
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83144,
                        Latitude = 23.99077,
                        Order = 230
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83159,
                        Latitude = 23.99078,
                        Order = 231
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83169,
                        Latitude = 23.99078,
                        Order = 232
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83213,
                        Latitude = 23.99078,
                        Order = 233
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83255,
                        Latitude = 23.99076,
                        Order = 234
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8329,
                        Latitude = 23.99076,
                        Order = 235
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83317,
                        Latitude = 23.99077,
                        Order = 236
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.833253,
                        Latitude = 23.990773,
                        Order = 237
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83344,
                        Latitude = 23.99078,
                        Order = 238
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.833885,
                        Latitude = 23.990805,
                        Order = 239
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.833952,
                        Latitude = 23.990817,
                        Order = 240
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.833952,
                        Latitude = 23.990817,
                        Order = 241
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83402,
                        Latitude = 23.99083,
                        Order = 242
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83425,
                        Latitude = 23.99088,
                        Order = 243
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83437,
                        Latitude = 23.99089,
                        Order = 244
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834441,
                        Latitude = 23.990883,
                        Order = 245
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834495,
                        Latitude = 23.990881,
                        Order = 246
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834644,
                        Latitude = 23.990869,
                        Order = 247
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834648,
                        Latitude = 23.990889,
                        Order = 248
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834708,
                        Latitude = 23.991147,
                        Order = 249
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834773,
                        Latitude = 23.991514,
                        Order = 250
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834856,
                        Latitude = 23.991984,
                        Order = 251
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834903,
                        Latitude = 23.992248,
                        Order = 252
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834973,
                        Latitude = 23.99264,
                        Order = 253
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.835044,
                        Latitude = 23.993032,
                        Order = 254
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.835138,
                        Latitude = 23.993595,
                        Order = 255
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.835192,
                        Latitude = 23.99392,
                        Order = 256
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83526,
                        Latitude = 23.99425,
                        Order = 257
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83537,
                        Latitude = 23.9949,
                        Order = 258
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83537,
                        Latitude = 23.9949,
                        Order = 259
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.835508,
                        Latitude = 23.995717,
                        Order = 260
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83566,
                        Latitude = 23.99653,
                        Order = 261
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83587,
                        Latitude = 23.99761,
                        Order = 262
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.835999,
                        Latitude = 23.998345,
                        Order = 263
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83602,
                        Latitude = 23.99848,
                        Order = 264
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8361,
                        Latitude = 23.99891,
                        Order = 265
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836178,
                        Latitude = 23.999351,
                        Order = 266
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836178,
                        Latitude = 23.999351,
                        Order = 267
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83636,
                        Latitude = 24.00038,
                        Order = 268
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83646,
                        Latitude = 24.00096,
                        Order = 269
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836665,
                        Latitude = 24.002043,
                        Order = 270
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836717,
                        Latitude = 24.002348,
                        Order = 271
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836751,
                        Latitude = 24.002507,
                        Order = 272
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83652,
                        Latitude = 24.00269,
                        Order = 273
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83606,
                        Latitude = 24.0031,
                        Order = 274
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.835959,
                        Latitude = 24.003193,
                        Order = 275
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.835959,
                        Latitude = 24.003193,
                        Order = 276
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.835616,
                        Latitude = 24.003507,
                        Order = 277
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83603,
                        Latitude = 24.00456,
                        Order = 278
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836047,
                        Latitude = 24.004587,
                        Order = 279
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836214,
                        Latitude = 24.004961,
                        Order = 280
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836482,
                        Latitude = 24.005588,
                        Order = 281
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83663,
                        Latitude = 24.005937,
                        Order = 282
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836931,
                        Latitude = 24.005671,
                        Order = 283
                    }
                };
                #endregion

                #region route 38 backward points
                var backwardPoints = new List<RoutePoint>
                {
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836931,
                        Latitude = 24.005671,
                        Order = 1
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837242,
                        Latitude = 24.005395,
                        Order = 2
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83727,
                        Latitude = 24.00537,
                        Order = 3
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837425,
                        Latitude = 24.005258,
                        Order = 4
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8375,
                        Latitude = 24.005201,
                        Order = 5
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837529,
                        Latitude = 24.005183,
                        Order = 6
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837491,
                        Latitude = 24.005077,
                        Order = 7
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83762,
                        Latitude = 24.00498,
                        Order = 8
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837648,
                        Latitude = 24.004289,
                        Order = 9
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837658,
                        Latitude = 24.004057,
                        Order = 10
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837639,
                        Latitude = 24.003795,
                        Order = 11
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837551,
                        Latitude = 24.003149,
                        Order = 12
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837523,
                        Latitude = 24.002937,
                        Order = 13
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837379,
                        Latitude = 24.00214,
                        Order = 14
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837138,
                        Latitude = 24.001963,
                        Order = 15
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837082,
                        Latitude = 24.0019,
                        Order = 16
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836902,
                        Latitude = 24.001747,
                        Order = 17
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836818,
                        Latitude = 24.001748,
                        Order = 18
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836711,
                        Latitude = 24.001267,
                        Order = 19
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83652,
                        Latitude = 24.00032,
                        Order = 20
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836356,
                        Latitude = 23.999387,
                        Order = 21
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836356,
                        Latitude = 23.999387,
                        Order = 22
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836161,
                        Latitude = 23.998277,
                        Order = 23
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83613,
                        Latitude = 23.998098,
                        Order = 24
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83591,
                        Latitude = 23.99689,
                        Order = 25
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.835679,
                        Latitude = 23.995668,
                        Order = 26
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.835508,
                        Latitude = 23.994763,
                        Order = 27
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.835508,
                        Latitude = 23.994763,
                        Order = 28
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83546,
                        Latitude = 23.99451,
                        Order = 29
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83546,
                        Latitude = 23.99439,
                        Order = 30
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83545,
                        Latitude = 23.99415,
                        Order = 31
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83545,
                        Latitude = 23.99362,
                        Order = 32
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8355,
                        Latitude = 23.99262,
                        Order = 33
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83552,
                        Latitude = 23.99192,
                        Order = 34
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83552,
                        Latitude = 23.99161,
                        Order = 35
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83551,
                        Latitude = 23.99137,
                        Order = 36
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83548,
                        Latitude = 23.9912,
                        Order = 37
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83545,
                        Latitude = 23.99109,
                        Order = 38
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83542,
                        Latitude = 23.99098,
                        Order = 39
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83536,
                        Latitude = 23.99083,
                        Order = 40
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83533,
                        Latitude = 23.99076,
                        Order = 41
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8353,
                        Latitude = 23.99073,
                        Order = 42
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83527,
                        Latitude = 23.9907,
                        Order = 43
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83524,
                        Latitude = 23.99067,
                        Order = 44
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8352,
                        Latitude = 23.99065,
                        Order = 45
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83516,
                        Latitude = 23.99063,
                        Order = 46
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83511,
                        Latitude = 23.99062,
                        Order = 47
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83506,
                        Latitude = 23.99062,
                        Order = 48
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.835,
                        Latitude = 23.99064,
                        Order = 49
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83493,
                        Latitude = 23.99066,
                        Order = 50
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83482,
                        Latitude = 23.99071,
                        Order = 51
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.834635,
                        Latitude = 23.990817,
                        Order = 52
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.834644,
                        Latitude = 23.990869,
                        Order = 53
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.834495,
                        Latitude = 23.990881,
                        Order = 54
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.834441,
                        Latitude = 23.990883,
                        Order = 55
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83437,
                        Latitude = 23.99089,
                        Order = 56
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83425,
                        Latitude = 23.99088,
                        Order = 57
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83402,
                        Latitude = 23.99083,
                        Order = 58
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.833952,
                        Latitude = 23.990817,
                        Order = 59
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.833885,
                        Latitude = 23.990805,
                        Order = 60
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83344,
                        Latitude = 23.99078,
                        Order = 61
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.833253,
                        Latitude = 23.990773,
                        Order = 62
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.833253,
                        Latitude = 23.990773,
                        Order = 63
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83317,
                        Latitude = 23.99077,
                        Order = 64
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8329,
                        Latitude = 23.99076,
                        Order = 65
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83255,
                        Latitude = 23.99076,
                        Order = 66
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83213,
                        Latitude = 23.99078,
                        Order = 67
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83169,
                        Latitude = 23.99078,
                        Order = 68
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83159,
                        Latitude = 23.99078,
                        Order = 69
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83144,
                        Latitude = 23.99077,
                        Order = 70
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83131,
                        Latitude = 23.99075,
                        Order = 71
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.831235,
                        Latitude = 23.990731,
                        Order = 72
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83119,
                        Latitude = 23.99072,
                        Order = 73
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83104,
                        Latitude = 23.99069,
                        Order = 74
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83057,
                        Latitude = 23.99056,
                        Order = 75
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.829986,
                        Latitude = 23.990404,
                        Order = 76
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.829986,
                        Latitude = 23.990404,
                        Order = 77
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82997,
                        Latitude = 23.9904,
                        Order = 78
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82956,
                        Latitude = 23.99031,
                        Order = 79
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82902,
                        Latitude = 23.99022,
                        Order = 80
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.828824,
                        Latitude = 23.990193,
                        Order = 81
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82823,
                        Latitude = 23.99013,
                        Order = 82
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.828062,
                        Latitude = 23.990119,
                        Order = 83
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82746,
                        Latitude = 23.99006,
                        Order = 84
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.826539,
                        Latitude = 23.989945,
                        Order = 85
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.826539,
                        Latitude = 23.989945,
                        Order = 86
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82586,
                        Latitude = 23.98986,
                        Order = 87
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.825395,
                        Latitude = 23.989788,
                        Order = 88
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82493,
                        Latitude = 23.98968,
                        Order = 89
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82488,
                        Latitude = 23.98967,
                        Order = 90
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82477,
                        Latitude = 23.98964,
                        Order = 91
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82458,
                        Latitude = 23.98959,
                        Order = 92
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82425,
                        Latitude = 23.9895,
                        Order = 93
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82391,
                        Latitude = 23.98941,
                        Order = 94
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8238,
                        Latitude = 23.98938,
                        Order = 95
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82369,
                        Latitude = 23.98936,
                        Order = 96
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82327,
                        Latitude = 23.98924,
                        Order = 97
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82301,
                        Latitude = 23.98916,
                        Order = 98
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82242,
                        Latitude = 23.98898,
                        Order = 99
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.821449,
                        Latitude = 23.988686,
                        Order = 100
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82121,
                        Latitude = 23.9886,
                        Order = 101
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82117,
                        Latitude = 23.98859,
                        Order = 102
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82069,
                        Latitude = 23.98844,
                        Order = 103
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81982,
                        Latitude = 23.98815,
                        Order = 104
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81955,
                        Latitude = 23.98807,
                        Order = 105
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.819322,
                        Latitude = 23.987986,
                        Order = 106
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.819322,
                        Latitude = 23.987986,
                        Order = 107
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8189,
                        Latitude = 23.98783,
                        Order = 108
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81874,
                        Latitude = 23.98776,
                        Order = 109
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.818565,
                        Latitude = 23.987675,
                        Order = 110
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81833,
                        Latitude = 23.98756,
                        Order = 111
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81775,
                        Latitude = 23.98723,
                        Order = 112
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81712,
                        Latitude = 23.98688,
                        Order = 113
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81498,
                        Latitude = 23.98568,
                        Order = 114
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813935,
                        Latitude = 23.985093,
                        Order = 115
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81352,
                        Latitude = 23.98486,
                        Order = 116
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81343,
                        Latitude = 23.98481,
                        Order = 117
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81334,
                        Latitude = 23.98476,
                        Order = 118
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8133,
                        Latitude = 23.984739,
                        Order = 119
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8133,
                        Latitude = 23.984739,
                        Order = 120
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813,
                        Latitude = 23.98458,
                        Order = 121
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.812859,
                        Latitude = 23.984456,
                        Order = 122
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81276,
                        Latitude = 23.98437,
                        Order = 123
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81264,
                        Latitude = 23.98427,
                        Order = 124
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81261,
                        Latitude = 23.98423,
                        Order = 125
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81258,
                        Latitude = 23.98418,
                        Order = 126
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81252,
                        Latitude = 23.98407,
                        Order = 127
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81249,
                        Latitude = 23.98401,
                        Order = 128
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81246,
                        Latitude = 23.98396,
                        Order = 129
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81242,
                        Latitude = 23.98389,
                        Order = 130
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.812368,
                        Latitude = 23.983841,
                        Order = 131
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81234,
                        Latitude = 23.9838,
                        Order = 132
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81233,
                        Latitude = 23.98376,
                        Order = 133
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81231,
                        Latitude = 23.98371,
                        Order = 134
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81229,
                        Latitude = 23.98367,
                        Order = 135
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.812278,
                        Latitude = 23.983602,
                        Order = 136
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8122,
                        Latitude = 23.98353,
                        Order = 137
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81215,
                        Latitude = 23.98349,
                        Order = 138
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81211,
                        Latitude = 23.98347,
                        Order = 139
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81207,
                        Latitude = 23.98346,
                        Order = 140
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81203,
                        Latitude = 23.98345,
                        Order = 141
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81197,
                        Latitude = 23.98345,
                        Order = 142
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811869,
                        Latitude = 23.983485,
                        Order = 143
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811838,
                        Latitude = 23.983525,
                        Order = 144
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811782,
                        Latitude = 23.9836,
                        Order = 145
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81176,
                        Latitude = 23.98365,
                        Order = 146
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81173,
                        Latitude = 23.98372,
                        Order = 147
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8117,
                        Latitude = 23.98379,
                        Order = 148
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81168,
                        Latitude = 23.98385,
                        Order = 149
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81168,
                        Latitude = 23.98386,
                        Order = 150
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81167,
                        Latitude = 23.98393,
                        Order = 151
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81167,
                        Latitude = 23.98401,
                        Order = 152
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811672,
                        Latitude = 23.984145,
                        Order = 153
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8117,
                        Latitude = 23.98424,
                        Order = 154
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81172,
                        Latitude = 23.9843,
                        Order = 155
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81174,
                        Latitude = 23.98435,
                        Order = 156
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811785,
                        Latitude = 23.984455,
                        Order = 157
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81186,
                        Latitude = 23.98491,
                        Order = 158
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8119,
                        Latitude = 23.985178,
                        Order = 159
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81189,
                        Latitude = 23.98524,
                        Order = 160
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81186,
                        Latitude = 23.98552,
                        Order = 161
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81182,
                        Latitude = 23.9859,
                        Order = 162
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81181,
                        Latitude = 23.98603,
                        Order = 163
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81171,
                        Latitude = 23.98704,
                        Order = 164
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81167,
                        Latitude = 23.98743,
                        Order = 165
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81156,
                        Latitude = 23.98858,
                        Order = 166
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81152,
                        Latitude = 23.98893,
                        Order = 167
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811495,
                        Latitude = 23.989258,
                        Order = 168
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81146,
                        Latitude = 23.98953,
                        Order = 169
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81144,
                        Latitude = 23.98985,
                        Order = 170
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8114,
                        Latitude = 23.9901,
                        Order = 171
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811385,
                        Latitude = 23.990265,
                        Order = 172
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81134,
                        Latitude = 23.99076,
                        Order = 173
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81131,
                        Latitude = 23.99105,
                        Order = 174
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8113,
                        Latitude = 23.9912,
                        Order = 175
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81125,
                        Latitude = 23.99162,
                        Order = 176
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811243,
                        Latitude = 23.991693,
                        Order = 177
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811243,
                        Latitude = 23.991693,
                        Order = 178
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81111,
                        Latitude = 23.99301,
                        Order = 179
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81104,
                        Latitude = 23.99365,
                        Order = 180
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81102,
                        Latitude = 23.99382,
                        Order = 181
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81101,
                        Latitude = 23.99393,
                        Order = 182
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81099,
                        Latitude = 23.99421,
                        Order = 183
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81085,
                        Latitude = 23.99553,
                        Order = 184
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810723,
                        Latitude = 23.996742,
                        Order = 185
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81068,
                        Latitude = 23.99715,
                        Order = 186
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81067,
                        Latitude = 23.9973,
                        Order = 187
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81065,
                        Latitude = 23.99751,
                        Order = 188
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81063,
                        Latitude = 23.99773,
                        Order = 189
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810583,
                        Latitude = 23.998153,
                        Order = 190
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810583,
                        Latitude = 23.998153,
                        Order = 191
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810508,
                        Latitude = 23.998824,
                        Order = 192
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810444,
                        Latitude = 23.99895,
                        Order = 193
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810382,
                        Latitude = 23.999089,
                        Order = 194
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810329,
                        Latitude = 23.999198,
                        Order = 195
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810277,
                        Latitude = 23.999341,
                        Order = 196
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81027,
                        Latitude = 23.99935,
                        Order = 197
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81026,
                        Latitude = 23.99936,
                        Order = 198
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81024,
                        Latitude = 23.99937,
                        Order = 199
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81023,
                        Latitude = 23.99939,
                        Order = 200
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81022,
                        Latitude = 23.9994,
                        Order = 201
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81021,
                        Latitude = 23.99942,
                        Order = 202
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8102,
                        Latitude = 23.99943,
                        Order = 203
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81019,
                        Latitude = 23.999452,
                        Order = 204
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81017,
                        Latitude = 23.9995,
                        Order = 205
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81014,
                        Latitude = 23.99955,
                        Order = 206
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81013,
                        Latitude = 23.99961,
                        Order = 207
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81012,
                        Latitude = 23.99967,
                        Order = 208
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81011,
                        Latitude = 23.99973,
                        Order = 209
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81011,
                        Latitude = 23.99979,
                        Order = 210
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81012,
                        Latitude = 23.99986,
                        Order = 211
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81013,
                        Latitude = 23.99992,
                        Order = 212
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810156,
                        Latitude = 23.999999,
                        Order = 213
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810179,
                        Latitude = 24.000044,
                        Order = 214
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810206,
                        Latitude = 24.000088,
                        Order = 215
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810241,
                        Latitude = 24.00013,
                        Order = 216
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81027,
                        Latitude = 24.00025,
                        Order = 217
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81031,
                        Latitude = 24.00041,
                        Order = 218
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810345,
                        Latitude = 24.000616,
                        Order = 219
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81032,
                        Latitude = 24.00077,
                        Order = 220
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810276,
                        Latitude = 24.001215,
                        Order = 221
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81016,
                        Latitude = 24.00238,
                        Order = 222
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81008,
                        Latitude = 24.00397,
                        Order = 223
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81008,
                        Latitude = 24.00411,
                        Order = 224
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810052,
                        Latitude = 24.004603,
                        Order = 225
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810052,
                        Latitude = 24.004603,
                        Order = 226
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81002,
                        Latitude = 24.00515,
                        Order = 227
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80994,
                        Latitude = 24.00672,
                        Order = 228
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80992,
                        Latitude = 24.00703,
                        Order = 229
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.809891,
                        Latitude = 24.007354,
                        Order = 230
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80989,
                        Latitude = 24.00736,
                        Order = 231
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80987,
                        Latitude = 24.00754,
                        Order = 232
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.809779,
                        Latitude = 24.008031,
                        Order = 233
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8096,
                        Latitude = 24.008,
                        Order = 234
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80938,
                        Latitude = 24.00795,
                        Order = 235
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80913,
                        Latitude = 24.00789,
                        Order = 236
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80844,
                        Latitude = 24.00771,
                        Order = 237
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80818,
                        Latitude = 24.00765,
                        Order = 238
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80799,
                        Latitude = 24.0076,
                        Order = 239
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.807929,
                        Latitude = 24.007586,
                        Order = 240
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8076,
                        Latitude = 24.00751,
                        Order = 241
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.807516,
                        Latitude = 24.00749,
                        Order = 242
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.807516,
                        Latitude = 24.00749,
                        Order = 243
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80706,
                        Latitude = 24.00738,
                        Order = 244
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80695,
                        Latitude = 24.00734,
                        Order = 245
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80683,
                        Latitude = 24.00731,
                        Order = 246
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.806558,
                        Latitude = 24.007245,
                        Order = 247
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8064,
                        Latitude = 24.00873,
                        Order = 248
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80631,
                        Latitude = 24.00958,
                        Order = 249
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80621,
                        Latitude = 24.01059,
                        Order = 250
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80619,
                        Latitude = 24.01069,
                        Order = 251
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80612,
                        Latitude = 24.01135,
                        Order = 252
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.806092,
                        Latitude = 24.0116,
                        Order = 253
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80606,
                        Latitude = 24.01188,
                        Order = 254
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.806036,
                        Latitude = 24.012096,
                        Order = 255
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.806036,
                        Latitude = 24.012096,
                        Order = 256
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80594,
                        Latitude = 24.01294,
                        Order = 257
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80585,
                        Latitude = 24.01377,
                        Order = 258
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80583,
                        Latitude = 24.01398,
                        Order = 259
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80581,
                        Latitude = 24.01419,
                        Order = 260
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80565,
                        Latitude = 24.01564,
                        Order = 261
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80559,
                        Latitude = 24.01625,
                        Order = 262
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.805423,
                        Latitude = 24.017742,
                        Order = 263
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8054,
                        Latitude = 24.01795,
                        Order = 264
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.805363,
                        Latitude = 24.018271,
                        Order = 265
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.805363,
                        Latitude = 24.018271,
                        Order = 266
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8053,
                        Latitude = 24.018812,
                        Order = 267
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80513,
                        Latitude = 24.01877,
                        Order = 268
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80496,
                        Latitude = 24.01872,
                        Order = 269
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80478,
                        Latitude = 24.01866,
                        Order = 270
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8046,
                        Latitude = 24.01861,
                        Order = 271
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80448,
                        Latitude = 24.01857,
                        Order = 272
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80438,
                        Latitude = 24.01854,
                        Order = 273
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80324,
                        Latitude = 24.01828,
                        Order = 274
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80304,
                        Latitude = 24.01823,
                        Order = 275
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.802614,
                        Latitude = 24.018134,
                        Order = 276
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80255,
                        Latitude = 24.01812,
                        Order = 277
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80223,
                        Latitude = 24.01804,
                        Order = 278
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.802179,
                        Latitude = 24.018026,
                        Order = 279
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.801937,
                        Latitude = 24.017898,
                        Order = 280
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.801925,
                        Latitude = 24.017996,
                        Order = 281
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.801914,
                        Latitude = 24.01813,
                        Order = 282
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80189,
                        Latitude = 24.01831,
                        Order = 283
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.801845,
                        Latitude = 24.018676,
                        Order = 284
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.801845,
                        Latitude = 24.018676,
                        Order = 285
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80167,
                        Latitude = 24.02012,
                        Order = 286
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.801641,
                        Latitude = 24.020297,
                        Order = 287
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.801588,
                        Latitude = 24.020499,
                        Order = 288
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80157,
                        Latitude = 24.02057,
                        Order = 289
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80156,
                        Latitude = 24.02064,
                        Order = 290
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80154,
                        Latitude = 24.02079,
                        Order = 291
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8015,
                        Latitude = 24.02114,
                        Order = 292
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80146,
                        Latitude = 24.02144,
                        Order = 293
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80129,
                        Latitude = 24.02272,
                        Order = 294
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80121,
                        Latitude = 24.02339,
                        Order = 295
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8011,
                        Latitude = 24.02409,
                        Order = 296
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80098,
                        Latitude = 24.02489,
                        Order = 297
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80073,
                        Latitude = 24.02681,
                        Order = 298
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80036,
                        Latitude = 24.03015,
                        Order = 299
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80034,
                        Latitude = 24.03031,
                        Order = 300
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.800304,
                        Latitude = 24.030603,
                        Order = 301
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.800304,
                        Latitude = 24.030603,
                        Order = 302
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80021,
                        Latitude = 24.03136,
                        Order = 303
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80009,
                        Latitude = 24.03254,
                        Order = 304
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8,
                        Latitude = 24.03337,
                        Order = 305
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79995,
                        Latitude = 24.03406,
                        Order = 306
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79992,
                        Latitude = 24.03469,
                        Order = 307
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.7999,
                        Latitude = 24.03521,
                        Order = 308
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.799896,
                        Latitude = 24.035393,
                        Order = 309
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.799896,
                        Latitude = 24.035393,
                        Order = 310
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79989,
                        Latitude = 24.03573,
                        Order = 311
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.7999,
                        Latitude = 24.03626,
                        Order = 312
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79994,
                        Latitude = 24.03691,
                        Order = 313
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79999,
                        Latitude = 24.03757,
                        Order = 314
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80011,
                        Latitude = 24.03863,
                        Order = 315
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80015,
                        Latitude = 24.03891,
                        Order = 316
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80024,
                        Latitude = 24.03941,
                        Order = 317
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80029,
                        Latitude = 24.03968,
                        Order = 318
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80035,
                        Latitude = 24.03993,
                        Order = 319
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80039,
                        Latitude = 24.04013,
                        Order = 320
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8005,
                        Latitude = 24.0406,
                        Order = 321
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.800518,
                        Latitude = 24.040669,
                        Order = 322
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.800518,
                        Latitude = 24.040669,
                        Order = 323
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80082,
                        Latitude = 24.04183,
                        Order = 324
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.800947,
                        Latitude = 24.042411,
                        Order = 325
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80103,
                        Latitude = 24.04272,
                        Order = 326
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80108,
                        Latitude = 24.04291,
                        Order = 327
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80117,
                        Latitude = 24.04329,
                        Order = 328
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80136,
                        Latitude = 24.04399,
                        Order = 329
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8014,
                        Latitude = 24.04421,
                        Order = 330
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80158,
                        Latitude = 24.0451,
                        Order = 331
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80164,
                        Latitude = 24.0454,
                        Order = 332
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.801662,
                        Latitude = 24.045484,
                        Order = 333
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.801662,
                        Latitude = 24.045484,
                        Order = 334
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80175,
                        Latitude = 24.04582,
                        Order = 335
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80178,
                        Latitude = 24.04594,
                        Order = 336
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80181,
                        Latitude = 24.04602,
                        Order = 337
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.801846,
                        Latitude = 24.046126,
                        Order = 338
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80191,
                        Latitude = 24.04606,
                        Order = 339
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80193,
                        Latitude = 24.04604,
                        Order = 340
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80195,
                        Latitude = 24.04602,
                        Order = 341
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.801975,
                        Latitude = 24.045998,
                        Order = 342
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80199,
                        Latitude = 24.04598,
                        Order = 343
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80201,
                        Latitude = 24.04594,
                        Order = 344
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80203,
                        Latitude = 24.04589,
                        Order = 345
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.801938,
                        Latitude = 24.04551,
                        Order = 346
                    }
                };

                #endregion

                context.RoutePoints.AddRange(forwardPoints);
                context.RoutePoints.AddRange(backwardPoints);
                context.SaveChanges();
            }
        }
    }
}