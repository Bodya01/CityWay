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
                        Name = "Скнилівок",
                        Direction = PointDirections.Backward,
                        Latitude = 49.813349000000002,
                        Longitude = 23.984514999999998,
                        Order = 9
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Боткіна",
                        Direction = PointDirections.Backward,
                        Latitude = 49.811157999999999,
                        Longitude = 23.991672000000001,
                        Order = 10
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Універмаг \"Океан\"",
                        Direction = PointDirections.Backward,
                        Latitude = 49.810513,
                        Longitude = 23.998134,
                        Order = 11
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Володимира Великого",
                        Direction = PointDirections.Backward,
                        Latitude = 49.809970999999997,
                        Longitude = 24.004591999999999,
                        Order = 12
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Тролейбусне депо",
                        Direction = PointDirections.Backward,
                        Latitude = 49.80753,
                        Longitude = 24.007344,
                        Order = 13
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Тролейбусне депо",
                        Direction = PointDirections.Backward,
                        Latitude = 49.80753,
                        Longitude = 24.007344,
                        Order = 13
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Івана Рубчака",
                        Direction = PointDirections.Backward,
                        Latitude = 49.806002999999997,
                        Longitude = 24.012087000000001,
                        Order = 14
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Боднарівка",
                        Direction = PointDirections.Backward,
                        Latitude = 49.805300000000003,
                        Longitude = 24.018253000000001,
                        Order = 15
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Стрийська - вул. Наукова",
                        Direction = PointDirections.Backward,
                        Latitude = 49.801704000000001,
                        Longitude = 24.018635,
                        Order = 16
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Демнянська",
                        Direction = PointDirections.Backward,
                        Latitude = 49.800265000000003,
                        Longitude = 24.030591000000001,
                        Order = 17
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "Духовна семінарія",
                        Direction = PointDirections.Backward,
                        Latitude = 49.799804999999999,
                        Longitude = 24.035388000000001,
                        Order = 18
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Чукаріна",
                        Direction = PointDirections.Backward,
                        Latitude = 49.800471000000002,
                        Longitude = 24.040697999999999,
                        Order = 19
                    },
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "вул. Хуторівка",
                        Direction = PointDirections.Backward,
                        Latitude = 49.801600000000001,
                        Longitude = 24.045522999999999,
                        Order = 20
                    },
                };

                var forwardStops = new List<Stop>
                {
                    new Stop
                    {
                        RouteId = route.Id,
                        Name = "ул. Хуторовка",
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
                        Latitude = 24.000,
                        Order = 117
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
                        Longitude = 49.836161,
                        Latitude = 23.998277,
                        Order = 22
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83613,
                        Latitude = 23.998098,
                        Order = 23
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83591,
                        Latitude = 23.99689,
                        Order = 24
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.835679,
                        Latitude = 23.995668,
                        Order = 25
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.835508,
                        Latitude = 23.994763,
                        Order = 26
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83546,
                        Latitude = 23.99451,
                        Order = 27
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83546,
                        Latitude = 23.99439,
                        Order = 28
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83545,
                        Latitude = 23.99415,
                        Order = 29
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83545,
                        Latitude = 23.99362,
                        Order = 30
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8355,
                        Latitude = 23.99262,
                        Order = 31
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83552,
                        Latitude = 23.99192,
                        Order = 32
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83552,
                        Latitude = 23.99161,
                        Order = 33
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83551,
                        Latitude = 23.99137,
                        Order = 34
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83548,
                        Latitude = 23.9912,
                        Order = 35
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83545,
                        Latitude = 23.99109,
                        Order = 36
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83542,
                        Latitude = 23.99098,
                        Order = 37
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83536,
                        Latitude = 23.99083,
                        Order = 38
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83533,
                        Latitude = 23.99076,
                        Order = 39
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8353,
                        Latitude = 23.99073,
                        Order = 40
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83527,
                        Latitude = 23.9907,
                        Order = 41
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83524,
                        Latitude = 23.99067,
                        Order = 42
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8352,
                        Latitude = 23.99065,
                        Order = 43
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83516,
                        Latitude = 23.99063,
                        Order = 44
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83511,
                        Latitude = 23.99062,
                        Order = 45
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83506,
                        Latitude = 23.99062,
                        Order = 46
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.835,
                        Latitude = 23.99064,
                        Order = 47
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83493,
                        Latitude = 23.99066,
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
                        Longitude = 49.83317,
                        Latitude = 23.99077,
                        Order = 63
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8329,
                        Latitude = 23.99076,
                        Order = 64
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83255,
                        Latitude = 23.99076,
                        Order = 65
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83213,
                        Latitude = 23.99078,
                        Order = 66
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83169,
                        Latitude = 23.99078,
                        Order = 67
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83159,
                        Latitude = 23.99078,
                        Order = 68
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83144,
                        Latitude = 23.99077,
                        Order = 69
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83131,
                        Latitude = 23.99075,
                        Order = 70
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.831235,
                        Latitude = 23.990731,
                        Order = 71
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83119,
                        Latitude = 23.99072,
                        Order = 72
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83104,
                        Latitude = 23.99069,
                        Order = 73
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83057,
                        Latitude = 23.99056,
                        Order = 74
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.829986,
                        Latitude = 23.990404,
                        Order = 75
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82997,
                        Latitude = 23.9904,
                        Order = 76
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82956,
                        Latitude = 23.99031,
                        Order = 77
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82902,
                        Latitude = 23.99022,
                        Order = 78
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.828824,
                        Latitude = 23.990193,
                        Order = 79
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82823,
                        Latitude = 23.99013,
                        Order = 80
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.828062,
                        Latitude = 23.990119,
                        Order = 81
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82746,
                        Latitude = 23.99006,
                        Order = 82
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.826539,
                        Latitude = 23.989945,
                        Order = 83
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82586,
                        Latitude = 23.98986,
                        Order = 84
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.825395,
                        Latitude = 23.989788,
                        Order = 85
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82493,
                        Latitude = 23.98968,
                        Order = 86
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82488,
                        Latitude = 23.98967,
                        Order = 87
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82477,
                        Latitude = 23.98964,
                        Order = 88
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82458,
                        Latitude = 23.98959,
                        Order = 89
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82425,
                        Latitude = 23.9895,
                        Order = 90
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82391,
                        Latitude = 23.98941,
                        Order = 91
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8238,
                        Latitude = 23.98938,
                        Order = 92
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82369,
                        Latitude = 23.98936,
                        Order = 93
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82327,
                        Latitude = 23.98924,
                        Order = 94
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82301,
                        Latitude = 23.98916,
                        Order = 95
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82242,
                        Latitude = 23.98898,
                        Order = 96
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.821449,
                        Latitude = 23.988686,
                        Order = 97
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82121,
                        Latitude = 23.9886,
                        Order = 98
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82117,
                        Latitude = 23.98859,
                        Order = 99
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82069,
                        Latitude = 23.98844,
                        Order = 100
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81982,
                        Latitude = 23.98815,
                        Order = 101
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81955,
                        Latitude = 23.98807,
                        Order = 102
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.819322,
                        Latitude = 23.987986,
                        Order = 103
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.819322,
                        Latitude = 23.987986,
                        Order = 104
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8189,
                        Latitude = 23.98783,
                        Order = 105
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81874,
                        Latitude = 23.98776,
                        Order = 106
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.818565,
                        Latitude = 23.987675,
                        Order = 107
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81833,
                        Latitude = 23.98756,
                        Order = 108
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81775,
                        Latitude = 23.98723,
                        Order = 109
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81712,
                        Latitude = 23.98688,
                        Order = 110
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81498,
                        Latitude = 23.98568,
                        Order = 111
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813935,
                        Latitude = 23.985093,
                        Order = 112
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81352,
                        Latitude = 23.98486,
                        Order = 113
                    },
                    new RoutePoint
                    {
                        RouteId = route.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81343,
                        Latitude = 23.98481,
                        Order = 114
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