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
                    },
                    new Route
                    {
                        CityId = city.Id,
                        Name = "3",
                        Type = RouteTypes.Tram,
                    },
                    new Route
                    {
                        CityId = city.Id,
                        Name = "16",
                        Type = RouteTypes.Bus,
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
                #endregion

                #region route 3 stops
                var route3 = context.Routes.First(x => x.Name == "3");

                var forward3Stops = new List<Stop>
                {
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "пл. Соборна",
                        Direction = PointDirections.Forward,
                        Latitude = 49.838123,
                        Longitude = 24.034927,
                        Order = 1
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "вул. Володимира Шухевича",
                        Direction = PointDirections.Forward,
                        Latitude = 49.836894,
                        Longitude = 24.034829,
                        Order = 2
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "вул. Саксаганського",
                        Direction = PointDirections.Forward,
                        Latitude = 49.834108,
                        Longitude = 24.034178,
                        Order = 3
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "пл. Івана Франка",
                        Direction = PointDirections.Forward,
                        Latitude = 49.830574,
                        Longitude = 24.032169,
                        Order = 4
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "Парк культури",
                        Direction = PointDirections.Forward,
                        Latitude = 49.830246,
                        Longitude = 24.02387,
                        Order = 5
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "пл. Станіслава Лема",
                        Direction = PointDirections.Forward,
                        Latitude = 49.831769,
                        Longitude = 24.017156,
                        Order = 6
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "вул. Івана Горбачевського",
                        Direction = PointDirections.Forward,
                        Latitude = 49.82735,
                        Longitude = 24.011262,
                        Order = 7
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "вул. Ісаєвича",
                        Direction = PointDirections.Forward,
                        Latitude = 49.822642,
                        Longitude = 24.006626,
                        Order = 8
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "вул. Аркаса",
                        Direction = PointDirections.Forward,
                        Latitude = 49.817435,
                        Longitude = 24.003097,
                        Order = 9
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "вул. Бойчука (Кіноцентр)",
                        Direction = PointDirections.Forward,
                        Latitude = 49.813019,
                        Longitude = 24.000462,
                        Order = 10
                    },
                };

                var backward3Stops = new List<Stop>
                {
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "Аквапарк",
                        Direction = PointDirections.Backward,
                        Latitude = 49.807189,
                        Longitude = 23.999022,
                        Order = 1
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "вул. Бойчука (Кіноцентр)",
                        Direction = PointDirections.Backward,
                        Latitude = 49.813655,
                        Longitude = 24.000897,
                        Order = 2
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "вул. Аркаса",
                        Direction = PointDirections.Backward,
                        Latitude = 49.817626,
                        Longitude = 24.003327,
                        Order = 3
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "вул. Ісаєвича",
                        Direction = PointDirections.Backward,
                        Latitude = 49.822521,
                        Longitude = 24.00664,
                        Order = 4
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "вул. Івана Горбачевського",
                        Direction = PointDirections.Backward,
                        Latitude = 49.827,
                        Longitude = 24.010943,
                        Order = 5
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "пл. Станіслава Лема",
                        Direction = PointDirections.Backward,
                        Latitude = 49.831817,
                        Longitude = 24.017376,
                        Order = 6
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "Парк культури",
                        Direction = PointDirections.Backward,
                        Latitude = 49.830238,
                        Longitude = 24.02322,
                        Order = 7
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "пл. Івана Франка",
                        Direction = PointDirections.Backward,
                        Latitude = 49.830101,
                        Longitude = 24.031246,
                        Order = 8
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "вул. Саксаганського",
                        Direction = PointDirections.Backward,
                        Latitude = 49.834446,
                        Longitude = 24.034435,
                        Order = 9
                    },
                    new Stop
                    {
                        RouteId = route3.Id,
                        Name = "пл. Соборна",
                        Direction = PointDirections.Backward,
                        Latitude = 49.838123,
                        Longitude = 24.034927,
                        Order = 10
                    },
                };

                #endregion

                #region route 16 stops
                var route16 = context.Routes.First(x => x.Name == "16");

                var forward16Stops = new List<Stop>
                {
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Залізничний вокзал (16)",
                        Direction = PointDirections.Backward,
                        Latitude = 49.839842,
                        Longitude = 23.995222,
                        Order = 1
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Приміський вокзал",
                        Direction = PointDirections.Backward,
                        Latitude = 49.838003,
                        Longitude = 23.999056,
                        Order = 2
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Привокзальний ринок",
                        Direction = PointDirections.Backward,
                        Latitude = 49.836464,
                        Longitude = 23.999341,
                        Order = 3
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "ТРЦ \"Скриня\"",
                        Direction = PointDirections.Backward,
                        Latitude = 49.835602,
                        Longitude = 23.994720,
                        Order = 4
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Кульпарківська",
                        Direction = PointDirections.Backward,
                        Latitude = 49.834530,
                        Longitude = 23.989849,
                        Order = 5
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Народна",
                        Direction = PointDirections.Backward,
                        Latitude = 49.833771,
                        Longitude = 23.985237,
                        Order = 6
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Стадіон \"Сільмаш\"",
                        Direction = PointDirections.Backward,
                        Latitude = 49.829204,
                        Longitude = 23.987235,
                        Order = 7
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Окружна",
                        Direction = PointDirections.Backward,
                        Latitude = 49.827376,
                        Longitude = 23.983153,
                        Order = 8
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Будинок Меблів",
                        Direction = PointDirections.Backward,
                        Latitude = 49.823981,
                        Longitude = 23.976722,
                        Order = 9
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Караджича",
                        Direction = PointDirections.Backward,
                        Latitude = 49.822226,
                        Longitude = 23.972830,
                        Order = 10
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Любінська-Виговського",
                        Direction = PointDirections.Backward,
                        Latitude = 49.820015,
                        Longitude = 23.969395,
                        Order = 11
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Скнилівський парк",
                        Direction = PointDirections.Backward,
                        Latitude = 49.817348,
                        Longitude = 23.971472,
                        Order = 12
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Ринок \"Південний\"",
                        Direction = PointDirections.Backward,
                        Latitude = 49.814327,
                        Longitude = 23.975199,
                        Order = 13
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Скнилівок",
                        Direction = PointDirections.Backward,
                        Latitude = 49.812101,
                        Longitude = 23.982125,
                        Order = 14
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Куровця",
                        Direction = PointDirections.Backward,
                        Latitude = 49.811158,
                        Longitude = 23.991672,
                        Order = 15
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Універмаг \"Океан\"",
                        Direction = PointDirections.Backward,
                        Latitude = 49.810513,
                        Longitude = 23.998134,
                        Order = 16
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Володимира Великого",
                        Direction = PointDirections.Backward,
                        Latitude = 49.809971,
                        Longitude = 24.004592,
                        Order = 17
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Коледж телекомунікацій",
                        Direction = PointDirections.Backward,
                        Latitude = 49.809580,
                        Longitude = 24.008673,
                        Order = 18
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Янева",
                        Direction = PointDirections.Backward,
                        Latitude = 49.808860,
                        Longitude = 24.012047,
                        Order = 19
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Автобусний завод",
                        Direction = PointDirections.Backward,
                        Latitude = 49.808476,
                        Longitude = 24.019371,
                        Order = 20
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Податкова",
                        Direction = PointDirections.Backward,
                        Latitude = 49.814613,
                        Longitude = 24.020458,
                        Order = 21
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Католицький університет",
                        Direction = PointDirections.Backward,
                        Latitude = 49.816700,
                        Longitude = 24.026630,
                        Order = 22
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Енергетична",
                        Direction = PointDirections.Backward,
                        Latitude = 49.815554,
                        Longitude = 24.030259,
                        Order = 23
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Херсонська",
                        Direction = PointDirections.Backward,
                        Latitude = 49.813770,
                        Longitude = 24.035749,
                        Order = 24
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Сумська",
                        Direction = PointDirections.Backward,
                        Latitude = 49.812893,
                        Longitude = 24.038120,
                        Order = 25
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Литвиненка",
                        Direction = PointDirections.Backward,
                        Latitude = 49.810849,
                        Longitude = 24.044167,
                        Order = 26
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Колодзінського",
                        Direction = PointDirections.Backward,
                        Latitude = 49.803199,
                        Longitude = 24.046020,
                        Order = 27
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "ТРЦ \"Шувар\"",
                        Direction = PointDirections.Backward,
                        Latitude = 49.798376,
                        Longitude = 24.049183,
                        Order = 28
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Дитяча поліклініка",
                        Direction = PointDirections.Backward,
                        Latitude = 49.797179,
                        Longitude = 24.051499,
                        Order = 29
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Івана Кавалерідзе",
                        Direction = PointDirections.Backward,
                        Latitude = 49.794643,
                        Longitude = 24.065088,
                        Order = 30
                    }
                };

                var backward16Stops = new List<Stop>
                {
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Івана Кавалерідзе (16)",
                        Direction = PointDirections.Forward,
                        Latitude = 49.794613,
                        Longitude = 24.063628,
                        Order = 1
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Центр Довженка",
                        Direction = PointDirections.Forward,
                        Latitude = 49.794716,
                        Longitude = 24.057659,
                        Order = 2
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Дитяча поліклініка",
                        Direction = PointDirections.Forward,
                        Latitude = 49.7965,
                        Longitude = 24.053867,
                        Order = 3
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "ТРЦ \"Шувар\"",
                        Direction = PointDirections.Forward,
                        Latitude = 49.799092,
                        Longitude = 24.048855,
                        Order = 4
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Колодзінського",
                        Direction = PointDirections.Forward,
                        Latitude = 49.803383,
                        Longitude = 24.046554,
                        Order = 5
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Угорська",
                        Direction = PointDirections.Forward,
                        Latitude = 49.810767,
                        Longitude = 24.044722,
                        Order = 6
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Віденська",
                        Direction = PointDirections.Forward,
                        Latitude = 49.812259,
                        Longitude = 24.042279,
                        Order = 7
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Литвиненка",
                        Direction = PointDirections.Forward,
                        Latitude = 49.813778,
                        Longitude = 24.042618,
                        Order = 8
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Херсонська",
                        Direction = PointDirections.Forward,
                        Latitude = 49.814018,
                        Longitude = 24.03561,
                        Order = 9
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Енергетична",
                        Direction = PointDirections.Forward,
                        Latitude = 49.815658,
                        Longitude = 24.030291,
                        Order = 10
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Католицький університет",
                        Direction = PointDirections.Forward,
                        Latitude = 49.816677,
                        Longitude = 24.025787,
                        Order = 11
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Податкова",
                        Direction = PointDirections.Forward,
                        Latitude = 49.814636,
                        Longitude = 24.023087,
                        Order = 12
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Автобусний завод",
                        Direction = PointDirections.Forward,
                        Latitude = 49.808384,
                        Longitude = 24.017029,
                        Order = 13
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Коледж телекомунікацій",
                        Direction = PointDirections.Forward,
                        Latitude = 49.809978,
                        Longitude = 24.007374,
                        Order = 14
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Володимира Великого",
                        Direction = PointDirections.Forward,
                        Latitude = 49.81045,
                        Longitude = 24.001257,
                        Order = 15
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Універмаг \"Океан\"",
                        Direction = PointDirections.Forward,
                        Latitude = 49.810882,
                        Longitude = 23.996783,
                        Order = 16
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Куровця",
                        Direction = PointDirections.Forward,
                        Latitude = 49.811497,
                        Longitude = 23.99029,
                        Order = 17
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Скнилівок",
                        Direction = PointDirections.Forward,
                        Latitude = 49.812326,
                        Longitude = 23.982136,
                        Order = 18
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Ринок \"Південний\"",
                        Direction = PointDirections.Forward,
                        Latitude = 49.813675,
                        Longitude = 23.976862,
                        Order = 19
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Скнилівський парк",
                        Direction = PointDirections.Forward,
                        Latitude = 49.816687,
                        Longitude = 23.972498,
                        Order = 20
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Любінська-Виговського",
                        Direction = PointDirections.Forward,
                        Latitude = 49.81963,
                        Longitude = 23.97002,
                        Order = 21
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Любінська-Виговського",
                        Direction = PointDirections.Forward,
                        Latitude = 49.820835,
                        Longitude = 23.96982,
                        Order = 22
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Караджича",
                        Direction = PointDirections.Forward,
                        Latitude = 49.822639,
                        Longitude = 23.974497,
                        Order = 23
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Будинок Меблів",
                        Direction = PointDirections.Forward,
                        Latitude = 49.824895,
                        Longitude = 23.979121,
                        Order = 24
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Окружна",
                        Direction = PointDirections.Forward,
                        Latitude = 49.827592,
                        Longitude = 23.982192,
                        Order = 25
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Богданівка",
                        Direction = PointDirections.Forward,
                        Latitude = 49.832482,
                        Longitude = 23.97916,
                        Order = 26
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Народна",
                        Direction = PointDirections.Forward,
                        Latitude = 49.833427,
                        Longitude = 23.984559,
                        Order = 27
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "вул. Кульпарківська",
                        Direction = PointDirections.Forward,
                        Latitude = 49.834461,
                        Longitude = 23.990053,
                        Order = 28
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "ТРЦ \"Скриня\"",
                        Direction = PointDirections.Forward,
                        Latitude = 49.835323,
                        Longitude = 23.994919,
                        Order = 29
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Привокзальний ринок",
                        Direction = PointDirections.Forward,
                        Latitude = 49.836125,
                        Longitude = 23.999374,
                        Order = 30
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Приміський вокзал",
                        Direction = PointDirections.Forward,
                        Latitude = 49.837715,
                        Longitude = 24.000225,
                        Order = 31
                    },
                    new Stop
                    {
                        RouteId = route16.Id,
                        Name = "Залізничний вокзал (16)",
                        Direction = PointDirections.Forward,
                        Latitude = 49.839842,
                        Longitude = 23.995222,
                        Order = 32
                    }
                };
                #endregion

                context.Stops.AddRange(forwardStops);
                context.Stops.AddRange(backwardStops);
                context.Stops.AddRange(forward3Stops);
                context.Stops.AddRange(backward3Stops);
                context.Stops.AddRange(forward16Stops);
                context.Stops.AddRange(backward16Stops);
                context.SaveChanges();
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

                #region route 3 points
                var route3 = context.Routes.First(x => x.Name == "3");

                var forward3Points = new List<RoutePoint>
                {
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.838131,
                        Latitude = 24.034964,
                        Order = 1
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.837785,
                        Latitude = 24.035144,
                        Order = 2
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.837712,
                        Latitude = 24.035136,
                        Order = 3
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8376,
                        Latitude = 24.035104,
                        Order = 4
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8374,
                        Latitude = 24.03503,
                        Order = 5
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.837398,
                        Latitude = 24.035029,
                        Order = 6
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83734,
                        Latitude = 24.03499,
                        Order = 7
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83727,
                        Latitude = 24.03497,
                        Order = 8
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83708,
                        Latitude = 24.03493,
                        Order = 9
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.837,
                        Latitude = 24.03492,
                        Order = 10
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836893,
                        Latitude = 24.034916,
                        Order = 11
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836893,
                        Latitude = 24.034916,
                        Order = 12
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83676,
                        Latitude = 24.03491,
                        Order = 13
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83652,
                        Latitude = 24.03492,
                        Order = 14
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836323,
                        Latitude = 24.034939,
                        Order = 15
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836208,
                        Latitude = 24.034954,
                        Order = 16
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836136,
                        Latitude = 24.034955,
                        Order = 17
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83604,
                        Latitude = 24.03496,
                        Order = 18
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83599,
                        Latitude = 24.03496,
                        Order = 19
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83577,
                        Latitude = 24.03497,
                        Order = 20
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83516,
                        Latitude = 24.03497,
                        Order = 21
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83509,
                        Latitude = 24.03497,
                        Order = 22
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83498,
                        Latitude = 24.03497,
                        Order = 23
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834955,
                        Latitude = 24.034963,
                        Order = 24
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83491,
                        Latitude = 24.034953,
                        Order = 25
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834879,
                        Latitude = 24.034946,
                        Order = 26
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83479,
                        Latitude = 24.03476,
                        Order = 27
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83474,
                        Latitude = 24.03466,
                        Order = 28
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83467,
                        Latitude = 24.03457,
                        Order = 29
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83461,
                        Latitude = 24.03449,
                        Order = 30
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83452,
                        Latitude = 24.03441,
                        Order = 31
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83447,
                        Latitude = 24.03437,
                        Order = 32
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83446,
                        Latitude = 24.034365,
                        Order = 33
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83441,
                        Latitude = 24.03434,
                        Order = 34
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83429,
                        Latitude = 24.0343,
                        Order = 35
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8341,
                        Latitude = 24.034255,
                        Order = 36
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8341,
                        Latitude = 24.034255,
                        Order = 37
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83383,
                        Latitude = 24.03419,
                        Order = 38
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.833717,
                        Latitude = 24.034157,
                        Order = 39
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83327,
                        Latitude = 24.03404,
                        Order = 40
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83267,
                        Latitude = 24.03387,
                        Order = 41
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83255,
                        Latitude = 24.03384,
                        Order = 42
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83234,
                        Latitude = 24.03379,
                        Order = 43
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83217,
                        Latitude = 24.03372,
                        Order = 44
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83199,
                        Latitude = 24.03362,
                        Order = 45
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83185,
                        Latitude = 24.03349,
                        Order = 46
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83147,
                        Latitude = 24.03317,
                        Order = 47
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83089,
                        Latitude = 24.03265,
                        Order = 48
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83055,
                        Latitude = 24.03229,
                        Order = 49
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.830527,
                        Latitude = 24.032262,
                        Order = 50
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.830527,
                        Latitude = 24.032262,
                        Order = 51
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83046,
                        Latitude = 24.03218,
                        Order = 52
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83026,
                        Latitude = 24.03189,
                        Order = 53
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.830241,
                        Latitude = 24.031851,
                        Order = 54
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.830211,
                        Latitude = 24.031713,
                        Order = 55
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.830146,
                        Latitude = 24.031371,
                        Order = 56
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.830115,
                        Latitude = 24.031238,
                        Order = 57
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.830025,
                        Latitude = 24.030858,
                        Order = 58
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.829982,
                        Latitude = 24.030558,
                        Order = 59
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82992,
                        Latitude = 24.03025,
                        Order = 60
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82973,
                        Latitude = 24.02931,
                        Order = 61
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82972,
                        Latitude = 24.02902,
                        Order = 62
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82972,
                        Latitude = 24.0285,
                        Order = 63
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8297,
                        Latitude = 24.02684,
                        Order = 64
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82971,
                        Latitude = 24.02659,
                        Order = 65
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82972,
                        Latitude = 24.02635,
                        Order = 66
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82977,
                        Latitude = 24.0259,
                        Order = 67
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82988,
                        Latitude = 24.02523,
                        Order = 68
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82996,
                        Latitude = 24.02488,
                        Order = 69
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.830166,
                        Latitude = 24.023832,
                        Order = 70
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.830166,
                        Latitude = 24.023832,
                        Order = 71
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.830188,
                        Latitude = 24.023722,
                        Order = 72
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.830298,
                        Latitude = 24.023254,
                        Order = 73
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83036,
                        Latitude = 24.02299,
                        Order = 74
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83044,
                        Latitude = 24.02266,
                        Order = 75
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83048,
                        Latitude = 24.02253,
                        Order = 76
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83049,
                        Latitude = 24.02249,
                        Order = 77
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83061,
                        Latitude = 24.02212,
                        Order = 78
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83068,
                        Latitude = 24.02194,
                        Order = 79
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83083,
                        Latitude = 24.02154,
                        Order = 80
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83086,
                        Latitude = 24.02146,
                        Order = 81
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83095,
                        Latitude = 24.02128,
                        Order = 82
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.832108,
                        Latitude = 24.018714,
                        Order = 83
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.832172,
                        Latitude = 24.018524,
                        Order = 84
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.832237,
                        Latitude = 24.018408,
                        Order = 85
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.832257,
                        Latitude = 24.018328,
                        Order = 86
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.832264,
                        Latitude = 24.018284,
                        Order = 87
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.832269,
                        Latitude = 24.018227,
                        Order = 88
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.832266,
                        Latitude = 24.018181,
                        Order = 89
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83226,
                        Latitude = 24.018129,
                        Order = 90
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.832251,
                        Latitude = 24.018082,
                        Order = 91
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.832232,
                        Latitude = 24.018023,
                        Order = 92
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.832077,
                        Latitude = 24.017717,
                        Order = 93
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.831849,
                        Latitude = 24.01733,
                        Order = 94
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.831757,
                        Latitude = 24.017173,
                        Order = 95
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.831757,
                        Latitude = 24.017173,
                        Order = 96
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.831708,
                        Latitude = 24.01709,
                        Order = 97
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.831284,
                        Latitude = 24.01637,
                        Order = 98
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.830897,
                        Latitude = 24.01565,
                        Order = 99
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.830647,
                        Latitude = 24.015204,
                        Order = 100
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.830491,
                        Latitude = 24.015036,
                        Order = 101
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.829925,
                        Latitude = 24.014417,
                        Order = 102
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.829719,
                        Latitude = 24.014137,
                        Order = 103
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.829488,
                        Latitude = 24.013818,
                        Order = 104
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.829284,
                        Latitude = 24.013488,
                        Order = 105
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.828992,
                        Latitude = 24.013098,
                        Order = 106
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.828714,
                        Latitude = 24.012749,
                        Order = 107
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.828602,
                        Latitude = 24.012658,
                        Order = 108
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.828244,
                        Latitude = 24.01245,
                        Order = 109
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.828033,
                        Latitude = 24.012221,
                        Order = 110
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.827771,
                        Latitude = 24.011839,
                        Order = 111
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.827375,
                        Latitude = 24.011343,
                        Order = 112
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.827335,
                        Latitude = 24.011288,
                        Order = 113
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.827335,
                        Latitude = 24.011288,
                        Order = 114
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.827034,
                        Latitude = 24.010883,
                        Order = 115
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.826993,
                        Latitude = 24.010828,
                        Order = 116
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.826635,
                        Latitude = 24.010377,
                        Order = 117
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82604,
                        Latitude = 24.009593,
                        Order = 118
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.825722,
                        Latitude = 24.009178,
                        Order = 119
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.825459,
                        Latitude = 24.008845,
                        Order = 120
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.825353,
                        Latitude = 24.008722,
                        Order = 121
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.825201,
                        Latitude = 24.008571,
                        Order = 122
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.825035,
                        Latitude = 24.00842,
                        Order = 123
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.824856,
                        Latitude = 24.008261,
                        Order = 124
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.824681,
                        Latitude = 24.008106,
                        Order = 125
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.824502,
                        Latitude = 24.007962,
                        Order = 126
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.823906,
                        Latitude = 24.007531,
                        Order = 127
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.823296,
                        Latitude = 24.007121,
                        Order = 128
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.822628,
                        Latitude = 24.006678,
                        Order = 129
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.822628,
                        Latitude = 24.006678,
                        Order = 130
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.822529,
                        Latitude = 24.006612,
                        Order = 131
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.822526,
                        Latitude = 24.00661,
                        Order = 132
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.821864,
                        Latitude = 24.006144,
                        Order = 133
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.820957,
                        Latitude = 24.005517,
                        Order = 134
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.820053,
                        Latitude = 24.004923,
                        Order = 135
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.819111,
                        Latitude = 24.004294,
                        Order = 136
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.818331,
                        Latitude = 24.003761,
                        Order = 137
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.818014,
                        Latitude = 24.003539,
                        Order = 138
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.817638,
                        Latitude = 24.003286,
                        Order = 139
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.817422,
                        Latitude = 24.003141,
                        Order = 140
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.817422,
                        Latitude = 24.003141,
                        Order = 141
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81736,
                        Latitude = 24.003099,
                        Order = 142
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.816842,
                        Latitude = 24.002748,
                        Order = 143
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.816267,
                        Latitude = 24.002369,
                        Order = 144
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.815899,
                        Latitude = 24.002128,
                        Order = 145
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.815407,
                        Latitude = 24.00178,
                        Order = 146
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.815056,
                        Latitude = 24.001566,
                        Order = 147
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.814377,
                        Latitude = 24.001202,
                        Order = 148
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813662,
                        Latitude = 24.000859,
                        Order = 149
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81363,
                        Latitude = 24.000844,
                        Order = 150
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813005,
                        Latitude = 24.000529,
                        Order = 151
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813005,
                        Latitude = 24.000529,
                        Order = 152
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813004,
                        Latitude = 24.000528,
                        Order = 153
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812829,
                        Latitude = 24.000427,
                        Order = 154
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812717,
                        Latitude = 24.00037,
                        Order = 155
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812622,
                        Latitude = 24.00033,
                        Order = 156
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812507,
                        Latitude = 24.000283,
                        Order = 157
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812389,
                        Latitude = 24.000243,
                        Order = 158
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.811924,
                        Latitude = 24.0001,
                        Order = 159
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810989,
                        Latitude = 23.999887,
                        Order = 160
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810389,
                        Latitude = 23.999741,
                        Order = 161
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.809827,
                        Latitude = 23.999597,
                        Order = 162
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.808946,
                        Latitude = 23.999391,
                        Order = 163
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.808046,
                        Latitude = 23.999172,
                        Order = 164
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.807196,
                        Latitude = 23.998956,
                        Order = 165
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.807158,
                        Latitude = 23.998947,
                        Order = 166
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.807075,
                        Latitude = 23.998925,
                        Order = 167
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.807075,
                        Latitude = 23.998925,
                        Order = 168
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806308,
                        Latitude = 23.998726,
                        Order = 169
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80626,
                        Latitude = 23.99871,
                        Order = 170
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806234,
                        Latitude = 23.998694,
                        Order = 171
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806209,
                        Latitude = 23.998672,
                        Order = 172
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806093,
                        Latitude = 23.998549,
                        Order = 173
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806017,
                        Latitude = 23.998456,
                        Order = 174
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805956,
                        Latitude = 23.9984,
                        Order = 175
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805919,
                        Latitude = 23.99838,
                        Order = 176
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805876,
                        Latitude = 23.998369,
                        Order = 177
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805836,
                        Latitude = 23.998372,
                        Order = 178
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805795,
                        Latitude = 23.998392,
                        Order = 179
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805762,
                        Latitude = 23.998429,
                        Order = 180
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80574,
                        Latitude = 23.998468,
                        Order = 181
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805721,
                        Latitude = 23.998519,
                        Order = 182
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805705,
                        Latitude = 23.998589,
                        Order = 183
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805702,
                        Latitude = 23.99868,
                        Order = 184
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805708,
                        Latitude = 23.998743,
                        Order = 185
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805722,
                        Latitude = 23.998798,
                        Order = 186
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80574,
                        Latitude = 23.998839,
                        Order = 187
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805765,
                        Latitude = 23.998883,
                        Order = 188
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805801,
                        Latitude = 23.998918,
                        Order = 189
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805833,
                        Latitude = 23.998934,
                        Order = 190
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805862,
                        Latitude = 23.998935,
                        Order = 191
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805913,
                        Latitude = 23.998928,
                        Order = 192
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805952,
                        Latitude = 23.998907,
                        Order = 193
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806094,
                        Latitude = 23.998822,
                        Order = 194
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806169,
                        Latitude = 23.99877,
                        Order = 195
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806193,
                        Latitude = 23.998756,
                        Order = 196
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806218,
                        Latitude = 23.998744,
                        Order = 197
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806261,
                        Latitude = 23.998734,
                        Order = 198
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806308,
                        Latitude = 23.998726,
                        Order = 199
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80626,
                        Latitude = 23.99871,
                        Order = 200
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806234,
                        Latitude = 23.998694,
                        Order = 201
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806209,
                        Latitude = 23.998672,
                        Order = 202
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806093,
                        Latitude = 23.998549,
                        Order = 203
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806017,
                        Latitude = 23.998456,
                        Order = 204
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805956,
                        Latitude = 23.9984,
                        Order = 205
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805919,
                        Latitude = 23.99838,
                        Order = 206
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805876,
                        Latitude = 23.998369,
                        Order = 207
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805836,
                        Latitude = 23.998372,
                        Order = 208
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805795,
                        Latitude = 23.998392,
                        Order = 209
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805762,
                        Latitude = 23.998429,
                        Order = 210
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80574,
                        Latitude = 23.998468,
                        Order = 211
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805721,
                        Latitude = 23.998519,
                        Order = 212
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805705,
                        Latitude = 23.998589,
                        Order = 213
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805702,
                        Latitude = 23.99868,
                        Order = 214
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805708,
                        Latitude = 23.998743,
                        Order = 215
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805722,
                        Latitude = 23.998798,
                        Order = 216
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80574,
                        Latitude = 23.998839,
                        Order = 217
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805765,
                        Latitude = 23.998883,
                        Order = 218
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805801,
                        Latitude = 23.998918,
                        Order = 219
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805833,
                        Latitude = 23.998934,
                        Order = 220
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805862,
                        Latitude = 23.998935,
                        Order = 221
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805913,
                        Latitude = 23.998928,
                        Order = 222
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.805952,
                        Latitude = 23.998907,
                        Order = 223
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806094,
                        Latitude = 23.998822,
                        Order = 224
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806169,
                        Latitude = 23.99877,
                        Order = 225
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806193,
                        Latitude = 23.998756,
                        Order = 226
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806218,
                        Latitude = 23.998744,
                        Order = 227
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806261,
                        Latitude = 23.998734,
                        Order = 228
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.806308,
                        Latitude = 23.998726,
                        Order = 229
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.807075,
                        Latitude = 23.998925,
                        Order = 230
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.807158,
                        Latitude = 23.998947,
                        Order = 231
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.807196,
                        Latitude = 23.998956,
                        Order = 232
                    }

                };
                var backward3Points = new List<RoutePoint>
                {
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.807196,
                        Latitude = 23.998956,
                        Order = 1
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.808046,
                        Latitude = 23.999172,
                        Order = 2
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.808946,
                        Latitude = 23.999391,
                        Order = 3
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.809827,
                        Latitude = 23.999597,
                        Order = 4
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810389,
                        Latitude = 23.999741,
                        Order = 5
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810989,
                        Latitude = 23.999887,
                        Order = 6
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811924,
                        Latitude = 24.0001,
                        Order = 7
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.812389,
                        Latitude = 24.000243,
                        Order = 8
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.812507,
                        Latitude = 24.000283,
                        Order = 9
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.812622,
                        Latitude = 24.00033,
                        Order = 10
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.812717,
                        Latitude = 24.00037,
                        Order = 11
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.812829,
                        Latitude = 24.000427,
                        Order = 12
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813004,
                        Latitude = 24.000528,
                        Order = 13
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813005,
                        Latitude = 24.000529,
                        Order = 14
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81363,
                        Latitude = 24.000844,
                        Order = 15
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813662,
                        Latitude = 24.000859,
                        Order = 16
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813662,
                        Latitude = 24.000859,
                        Order = 17
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.814377,
                        Latitude = 24.001202,
                        Order = 18
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.815056,
                        Latitude = 24.001566,
                        Order = 19
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.815407,
                        Latitude = 24.00178,
                        Order = 20
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.815899,
                        Latitude = 24.002128,
                        Order = 21
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.816267,
                        Latitude = 24.002369,
                        Order = 22
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.816842,
                        Latitude = 24.002748,
                        Order = 23
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81736,
                        Latitude = 24.003099,
                        Order = 24
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.817422,
                        Latitude = 24.003141,
                        Order = 25
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.817638,
                        Latitude = 24.003286,
                        Order = 26
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.817638,
                        Latitude = 24.003286,
                        Order = 27
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.818014,
                        Latitude = 24.003539,
                        Order = 28
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.818331,
                        Latitude = 24.003761,
                        Order = 29
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.819111,
                        Latitude = 24.004294,
                        Order = 30
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.820053,
                        Latitude = 24.004923,
                        Order = 31
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.820957,
                        Latitude = 24.005517,
                        Order = 32
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.821864,
                        Latitude = 24.006144,
                        Order = 33
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.822526,
                        Latitude = 24.00661,
                        Order = 34
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.822529,
                        Latitude = 24.006612,
                        Order = 35
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.822529,
                        Latitude = 24.006612,
                        Order = 36
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.822628,
                        Latitude = 24.006678,
                        Order = 37
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.823296,
                        Latitude = 24.007121,
                        Order = 38
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.823906,
                        Latitude = 24.007531,
                        Order = 39
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.824502,
                        Latitude = 24.007962,
                        Order = 40
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.824681,
                        Latitude = 24.008106,
                        Order = 41
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.824856,
                        Latitude = 24.008261,
                        Order = 42
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.825035,
                        Latitude = 24.00842,
                        Order = 43
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.825201,
                        Latitude = 24.008571,
                        Order = 44
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.825353,
                        Latitude = 24.008722,
                        Order = 45
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.825459,
                        Latitude = 24.008845,
                        Order = 46
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.825722,
                        Latitude = 24.009178,
                        Order = 47
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82604,
                        Latitude = 24.009593,
                        Order = 48
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.826635,
                        Latitude = 24.010377,
                        Order = 49
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.826993,
                        Latitude = 24.010828,
                        Order = 50
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.827034,
                        Latitude = 24.010883,
                        Order = 51
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.827034,
                        Latitude = 24.010883,
                        Order = 52
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.827335,
                        Latitude = 24.011288,
                        Order = 53
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.827375,
                        Latitude = 24.011343,
                        Order = 54
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.827771,
                        Latitude = 24.011839,
                        Order = 55
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.828033,
                        Latitude = 24.012221,
                        Order = 56
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.828244,
                        Latitude = 24.01245,
                        Order = 57
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.828602,
                        Latitude = 24.012658,
                        Order = 58
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.828714,
                        Latitude = 24.012749,
                        Order = 59
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.828992,
                        Latitude = 24.013098,
                        Order = 60
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.829284,
                        Latitude = 24.013488,
                        Order = 61
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.829488,
                        Latitude = 24.013818,
                        Order = 62
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.829719,
                        Latitude = 24.014137,
                        Order = 63
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.829925,
                        Latitude = 24.014417,
                        Order = 64
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.830491,
                        Latitude = 24.015036,
                        Order = 65
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.830647,
                        Latitude = 24.015204,
                        Order = 66
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.830897,
                        Latitude = 24.01565,
                        Order = 67
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.831284,
                        Latitude = 24.01637,
                        Order = 68
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.831708,
                        Latitude = 24.01709,
                        Order = 69
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.831757,
                        Latitude = 24.017173,
                        Order = 70
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.831849,
                        Latitude = 24.01733,
                        Order = 71
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.831849,
                        Latitude = 24.01733,
                        Order = 72
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.832077,
                        Latitude = 24.017717,
                        Order = 73
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.832232,
                        Latitude = 24.018023,
                        Order = 74
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.832251,
                        Latitude = 24.018082,
                        Order = 75
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83226,
                        Latitude = 24.018129,
                        Order = 76
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.832266,
                        Latitude = 24.018181,
                        Order = 77
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.832269,
                        Latitude = 24.018227,
                        Order = 78
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.832264,
                        Latitude = 24.018284,
                        Order = 79
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.832257,
                        Latitude = 24.018328,
                        Order = 80
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.832237,
                        Latitude = 24.018408,
                        Order = 81
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.832172,
                        Latitude = 24.018524,
                        Order = 82
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.832108,
                        Latitude = 24.018714,
                        Order = 83
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83095,
                        Latitude = 24.02128,
                        Order = 84
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83086,
                        Latitude = 24.02146,
                        Order = 85
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83083,
                        Latitude = 24.02154,
                        Order = 86
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83068,
                        Latitude = 24.02194,
                        Order = 87
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83061,
                        Latitude = 24.02212,
                        Order = 88
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83049,
                        Latitude = 24.02249,
                        Order = 89
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83048,
                        Latitude = 24.02253,
                        Order = 90
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83044,
                        Latitude = 24.02266,
                        Order = 91
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83036,
                        Latitude = 24.02299,
                        Order = 92
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.830298,
                        Latitude = 24.023254,
                        Order = 93
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.830298,
                        Latitude = 24.023254,
                        Order = 94
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.830188,
                        Latitude = 24.023722,
                        Order = 95
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.830166,
                        Latitude = 24.023832,
                        Order = 96
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82996,
                        Latitude = 24.02488,
                        Order = 97
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82988,
                        Latitude = 24.02523,
                        Order = 98
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82977,
                        Latitude = 24.0259,
                        Order = 99
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82972,
                        Latitude = 24.02635,
                        Order = 100
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82971,
                        Latitude = 24.02659,
                        Order = 101
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8297,
                        Latitude = 24.02684,
                        Order = 102
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82972,
                        Latitude = 24.0285,
                        Order = 103
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82972,
                        Latitude = 24.02902,
                        Order = 104
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82973,
                        Latitude = 24.02931,
                        Order = 105
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82992,
                        Latitude = 24.03025,
                        Order = 106
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.829982,
                        Latitude = 24.030558,
                        Order = 107
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.830025,
                        Latitude = 24.030858,
                        Order = 108
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.830115,
                        Latitude = 24.031238,
                        Order = 109
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.830115,
                        Latitude = 24.031238,
                        Order = 110
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.830146,
                        Latitude = 24.031371,
                        Order = 111
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.830211,
                        Latitude = 24.031713,
                        Order = 112
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.830241,
                        Latitude = 24.031851,
                        Order = 113
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83026,
                        Latitude = 24.03189,
                        Order = 114
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83046,
                        Latitude = 24.03218,
                        Order = 115
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.830527,
                        Latitude = 24.032262,
                        Order = 116
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83055,
                        Latitude = 24.03229,
                        Order = 117
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83089,
                        Latitude = 24.03265,
                        Order = 118
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83147,
                        Latitude = 24.03317,
                        Order = 119
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83185,
                        Latitude = 24.03349,
                        Order = 120
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83199,
                        Latitude = 24.03362,
                        Order = 121
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83217,
                        Latitude = 24.03372,
                        Order = 122
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83234,
                        Latitude = 24.03379,
                        Order = 123
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83255,
                        Latitude = 24.03384,
                        Order = 124
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83267,
                        Latitude = 24.03387,
                        Order = 125
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83327,
                        Latitude = 24.03404,
                        Order = 126
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.833717,
                        Latitude = 24.034157,
                        Order = 127
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83383,
                        Latitude = 24.03419,
                        Order = 128
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8341,
                        Latitude = 24.034255,
                        Order = 129
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83429,
                        Latitude = 24.0343,
                        Order = 130
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83441,
                        Latitude = 24.03434,
                        Order = 131
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83446,
                        Latitude = 24.034365,
                        Order = 132
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83446,
                        Latitude = 24.034365,
                        Order = 133
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83447,
                        Latitude = 24.03437,
                        Order = 134
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83452,
                        Latitude = 24.03441,
                        Order = 135
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83461,
                        Latitude = 24.03449,
                        Order = 136
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83467,
                        Latitude = 24.03457,
                        Order = 137
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83474,
                        Latitude = 24.03466,
                        Order = 138
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83479,
                        Latitude = 24.03476,
                        Order = 139
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.834879,
                        Latitude = 24.034946,
                        Order = 140
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83491,
                        Latitude = 24.034953,
                        Order = 141
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.834955,
                        Latitude = 24.034963,
                        Order = 142
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83498,
                        Latitude = 24.03497,
                        Order = 143
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83509,
                        Latitude = 24.03497,
                        Order = 144
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83516,
                        Latitude = 24.03497,
                        Order = 145
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83577,
                        Latitude = 24.03497,
                        Order = 146
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83599,
                        Latitude = 24.03496,
                        Order = 147
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83604,
                        Latitude = 24.03496,
                        Order = 148
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836136,
                        Latitude = 24.034955,
                        Order = 149
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836208,
                        Latitude = 24.034954,
                        Order = 150
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836323,
                        Latitude = 24.034939,
                        Order = 151
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83652,
                        Latitude = 24.03492,
                        Order = 152
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83676,
                        Latitude = 24.03491,
                        Order = 153
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836893,
                        Latitude = 24.034916,
                        Order = 154
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837,
                        Latitude = 24.03492,
                        Order = 155
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83708,
                        Latitude = 24.03493,
                        Order = 156
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83727,
                        Latitude = 24.03497,
                        Order = 157
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83734,
                        Latitude = 24.03499,
                        Order = 158
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837398,
                        Latitude = 24.035029,
                        Order = 159
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8374,
                        Latitude = 24.03503,
                        Order = 160
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8376,
                        Latitude = 24.035104,
                        Order = 161
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837712,
                        Latitude = 24.035136,
                        Order = 162
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837785,
                        Latitude = 24.035144,
                        Order = 163
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838147,
                        Latitude = 24.035232,
                        Order = 164
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838583,
                        Latitude = 24.035321,
                        Order = 165
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838745,
                        Latitude = 24.035245,
                        Order = 166
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838785,
                        Latitude = 24.035215,
                        Order = 167
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838817,
                        Latitude = 24.035165,
                        Order = 168
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838836,
                        Latitude = 24.035112,
                        Order = 169
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838851,
                        Latitude = 24.035043,
                        Order = 170
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838856,
                        Latitude = 24.034976,
                        Order = 171
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838855,
                        Latitude = 24.034917,
                        Order = 172
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838841,
                        Latitude = 24.034863,
                        Order = 173
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838822,
                        Latitude = 24.034819,
                        Order = 174
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838792,
                        Latitude = 24.034781,
                        Order = 175
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838751,
                        Latitude = 24.034747,
                        Order = 176
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838718,
                        Latitude = 24.034728,
                        Order = 177
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83868,
                        Latitude = 24.034718,
                        Order = 178
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838616,
                        Latitude = 24.034736,
                        Order = 179
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838215,
                        Latitude = 24.03492,
                        Order = 180
                    },
                    new RoutePoint
                    {
                        RouteId = route3.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838131,
                        Latitude = 24.034964,
                        Order = 181
                    }
                };
                #endregion

                #region route 16 points
                var route16 = context.Routes.First(x => x.Name == "16");

                var forward16Points = new List<RoutePoint>
                {
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.794475,
                        Latitude = 24.063699,
                        Order = 1
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.794447,
                        Latitude = 24.063572,
                        Order = 2
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79441,
                        Latitude = 24.063383,
                        Order = 3
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.794326,
                        Latitude = 24.062953,
                        Order = 4
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.794077,
                        Latitude = 24.061678,
                        Order = 5
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79398,
                        Latitude = 24.06118,
                        Order = 6
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79392,
                        Latitude = 24.06076,
                        Order = 7
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79391,
                        Latitude = 24.06067,
                        Order = 8
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.7939,
                        Latitude = 24.06058,
                        Order = 9
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79389,
                        Latitude = 24.06048,
                        Order = 10
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79388,
                        Latitude = 24.06007,
                        Order = 11
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79388,
                        Latitude = 24.05996,
                        Order = 12
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79386,
                        Latitude = 24.05874,
                        Order = 13
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.793846,
                        Latitude = 24.05866,
                        Order = 14
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79393,
                        Latitude = 24.05843,
                        Order = 15
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79396,
                        Latitude = 24.05835,
                        Order = 16
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79399,
                        Latitude = 24.0583,
                        Order = 17
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79402,
                        Latitude = 24.05825,
                        Order = 18
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79409,
                        Latitude = 24.058164,
                        Order = 19
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.794226,
                        Latitude = 24.058017,
                        Order = 20
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.794373,
                        Latitude = 24.057865,
                        Order = 21
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.794548,
                        Latitude = 24.057641,
                        Order = 22
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.794577,
                        Latitude = 24.057598,
                        Order = 23
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.794621,
                        Latitude = 24.057522,
                        Order = 24
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.794621,
                        Latitude = 24.057522,
                        Order = 25
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79489,
                        Latitude = 24.05707,
                        Order = 26
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79496,
                        Latitude = 24.05689,
                        Order = 27
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79503,
                        Latitude = 24.05672,
                        Order = 28
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79519,
                        Latitude = 24.05633,
                        Order = 29
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79549,
                        Latitude = 24.05564,
                        Order = 30
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79568,
                        Latitude = 24.05523,
                        Order = 31
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79589,
                        Latitude = 24.0548,
                        Order = 32
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79623,
                        Latitude = 24.05408,
                        Order = 33
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.796397,
                        Latitude = 24.053743,
                        Order = 34
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.796397,
                        Latitude = 24.053743,
                        Order = 35
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.796541,
                        Latitude = 24.053456,
                        Order = 36
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79701,
                        Latitude = 24.05256,
                        Order = 37
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79777,
                        Latitude = 24.05114,
                        Order = 38
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79802,
                        Latitude = 24.05066,
                        Order = 39
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79825,
                        Latitude = 24.05019,
                        Order = 40
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.7987,
                        Latitude = 24.04929,
                        Order = 41
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79873,
                        Latitude = 24.04925,
                        Order = 42
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79883,
                        Latitude = 24.04908,
                        Order = 43
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79885,
                        Latitude = 24.04902,
                        Order = 44
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.799003,
                        Latitude = 24.048739,
                        Order = 45
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.799003,
                        Latitude = 24.048739,
                        Order = 46
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79903,
                        Latitude = 24.04869,
                        Order = 47
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79918,
                        Latitude = 24.04842,
                        Order = 48
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79929,
                        Latitude = 24.04828,
                        Order = 49
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79938,
                        Latitude = 24.04817,
                        Order = 50
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.7995,
                        Latitude = 24.04805,
                        Order = 51
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.79958,
                        Latitude = 24.04795,
                        Order = 52
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.799745,
                        Latitude = 24.047783,
                        Order = 53
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.800341,
                        Latitude = 24.04726,
                        Order = 54
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8006,
                        Latitude = 24.04707,
                        Order = 55
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80079,
                        Latitude = 24.04695,
                        Order = 56
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80095,
                        Latitude = 24.04686,
                        Order = 57
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80116,
                        Latitude = 24.04674,
                        Order = 58
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80154,
                        Latitude = 24.04665,
                        Order = 59
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80179,
                        Latitude = 24.04659,
                        Order = 60
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80182,
                        Latitude = 24.04659,
                        Order = 61
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80237,
                        Latitude = 24.04649,
                        Order = 62
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80254,
                        Latitude = 24.04645,
                        Order = 63
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80314,
                        Latitude = 24.0464,
                        Order = 64
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80331,
                        Latitude = 24.04638,
                        Order = 65
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80338,
                        Latitude = 24.046378,
                        Order = 66
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80338,
                        Latitude = 24.046378,
                        Order = 67
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80359,
                        Latitude = 24.04637,
                        Order = 68
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8039,
                        Latitude = 24.04639,
                        Order = 69
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.804227,
                        Latitude = 24.046412,
                        Order = 70
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80479,
                        Latitude = 24.04656,
                        Order = 71
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80537,
                        Latitude = 24.04672,
                        Order = 72
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80587,
                        Latitude = 24.04679,
                        Order = 73
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80597,
                        Latitude = 24.04681,
                        Order = 74
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80636,
                        Latitude = 24.04689,
                        Order = 75
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80667,
                        Latitude = 24.04694,
                        Order = 76
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80697,
                        Latitude = 24.04699,
                        Order = 77
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80732,
                        Latitude = 24.04702,
                        Order = 78
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80766,
                        Latitude = 24.04704,
                        Order = 79
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.807869,
                        Latitude = 24.04704,
                        Order = 80
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.808386,
                        Latitude = 24.046957,
                        Order = 81
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80865,
                        Latitude = 24.04692,
                        Order = 82
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80888,
                        Latitude = 24.04688,
                        Order = 83
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80944,
                        Latitude = 24.04674,
                        Order = 84
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81001,
                        Latitude = 24.04659,
                        Order = 85
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810227,
                        Latitude = 24.046549,
                        Order = 86
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810248,
                        Latitude = 24.046226,
                        Order = 87
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81044,
                        Latitude = 24.04553,
                        Order = 88
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810725,
                        Latitude = 24.044688,
                        Order = 89
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810725,
                        Latitude = 24.044688,
                        Order = 90
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81089,
                        Latitude = 24.0442,
                        Order = 91
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81092,
                        Latitude = 24.04411,
                        Order = 92
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81119,
                        Latitude = 24.04329,
                        Order = 93
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81142,
                        Latitude = 24.04262,
                        Order = 94
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81152,
                        Latitude = 24.04232,
                        Order = 95
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81164,
                        Latitude = 24.04197,
                        Order = 96
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81173,
                        Latitude = 24.04173,
                        Order = 97
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.811779,
                        Latitude = 24.041604,
                        Order = 98
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8118,
                        Latitude = 24.04174,
                        Order = 99
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81182,
                        Latitude = 24.04179,
                        Order = 100
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81185,
                        Latitude = 24.04183,
                        Order = 101
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81211,
                        Latitude = 24.04203,
                        Order = 102
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812293,
                        Latitude = 24.042182,
                        Order = 103
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812293,
                        Latitude = 24.042182,
                        Order = 104
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81246,
                        Latitude = 24.04232,
                        Order = 105
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81293,
                        Latitude = 24.04273,
                        Order = 106
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81307,
                        Latitude = 24.04285,
                        Order = 107
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81329,
                        Latitude = 24.04306,
                        Order = 108
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81339,
                        Latitude = 24.04319,
                        Order = 109
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81351,
                        Latitude = 24.043322,
                        Order = 110
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81358,
                        Latitude = 24.04336,
                        Order = 111
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81363,
                        Latitude = 24.04338,
                        Order = 112
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8137,
                        Latitude = 24.04341,
                        Order = 113
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813723,
                        Latitude = 24.04341,
                        Order = 114
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8137,
                        Latitude = 24.04268,
                        Order = 115
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813697,
                        Latitude = 24.042628,
                        Order = 116
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813697,
                        Latitude = 24.042628,
                        Order = 117
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81368,
                        Latitude = 24.0423,
                        Order = 118
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81367,
                        Latitude = 24.04184,
                        Order = 119
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81365,
                        Latitude = 24.04125,
                        Order = 120
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81363,
                        Latitude = 24.04073,
                        Order = 121
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81362,
                        Latitude = 24.04023,
                        Order = 122
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81361,
                        Latitude = 24.04005,
                        Order = 123
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8136,
                        Latitude = 24.03977,
                        Order = 124
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81356,
                        Latitude = 24.03917,
                        Order = 125
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81354,
                        Latitude = 24.03874,
                        Order = 126
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81354,
                        Latitude = 24.03868,
                        Order = 127
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81351,
                        Latitude = 24.03783,
                        Order = 128
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813485,
                        Latitude = 24.037455,
                        Order = 129
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813462,
                        Latitude = 24.037232,
                        Order = 130
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813482,
                        Latitude = 24.037236,
                        Order = 131
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813498,
                        Latitude = 24.037232,
                        Order = 132
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813523,
                        Latitude = 24.037224,
                        Order = 133
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813549,
                        Latitude = 24.037207,
                        Order = 134
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813572,
                        Latitude = 24.037186,
                        Order = 135
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813592,
                        Latitude = 24.037153,
                        Order = 136
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813599,
                        Latitude = 24.037128,
                        Order = 137
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813601,
                        Latitude = 24.037097,
                        Order = 138
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813598,
                        Latitude = 24.037063,
                        Order = 139
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813591,
                        Latitude = 24.037033,
                        Order = 140
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81358,
                        Latitude = 24.037005,
                        Order = 141
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813571,
                        Latitude = 24.036984,
                        Order = 142
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813562,
                        Latitude = 24.036774,
                        Order = 143
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81373,
                        Latitude = 24.0363,
                        Order = 144
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813878,
                        Latitude = 24.035832,
                        Order = 145
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81393,
                        Latitude = 24.03567,
                        Order = 146
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813963,
                        Latitude = 24.035567,
                        Order = 147
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813963,
                        Latitude = 24.035567,
                        Order = 148
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81433,
                        Latitude = 24.03441,
                        Order = 149
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.814354,
                        Latitude = 24.034322,
                        Order = 150
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8146,
                        Latitude = 24.03355,
                        Order = 151
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81467,
                        Latitude = 24.03327,
                        Order = 152
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81502,
                        Latitude = 24.03214,
                        Order = 153
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81561,
                        Latitude = 24.03032,
                        Order = 154
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.815614,
                        Latitude = 24.030306,
                        Order = 155
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.815627,
                        Latitude = 24.030267,
                        Order = 156
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.815627,
                        Latitude = 24.030267,
                        Order = 157
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81571,
                        Latitude = 24.03001,
                        Order = 158
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81574,
                        Latitude = 24.0299,
                        Order = 159
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81603,
                        Latitude = 24.02891,
                        Order = 160
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81631,
                        Latitude = 24.02798,
                        Order = 161
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81669,
                        Latitude = 24.02677,
                        Order = 162
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.816726,
                        Latitude = 24.02665,
                        Order = 163
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.816926,
                        Latitude = 24.025986,
                        Order = 164
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81679,
                        Latitude = 24.02596,
                        Order = 165
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.816667,
                        Latitude = 24.025941,
                        Order = 166
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.816667,
                        Latitude = 24.025941,
                        Order = 167
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81615,
                        Latitude = 24.02586,
                        Order = 168
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81608,
                        Latitude = 24.02584,
                        Order = 169
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8155,
                        Latitude = 24.02574,
                        Order = 170
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81535,
                        Latitude = 24.02571,
                        Order = 171
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81524,
                        Latitude = 24.0257,
                        Order = 172
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.814458,
                        Latitude = 24.0256,
                        Order = 173
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81449,
                        Latitude = 24.02467,
                        Order = 174
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.814546,
                        Latitude = 24.023079,
                        Order = 175
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.814546,
                        Latitude = 24.023079,
                        Order = 176
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81456,
                        Latitude = 24.02269,
                        Order = 177
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81457,
                        Latitude = 24.02261,
                        Order = 178
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81462,
                        Latitude = 24.02127,
                        Order = 179
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81464,
                        Latitude = 24.02084,
                        Order = 180
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.814645,
                        Latitude = 24.020459,
                        Order = 181
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.814652,
                        Latitude = 24.019849,
                        Order = 182
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81449,
                        Latitude = 24.01983,
                        Order = 183
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81431,
                        Latitude = 24.01981,
                        Order = 184
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81322,
                        Latitude = 24.0197,
                        Order = 185
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81282,
                        Latitude = 24.01966,
                        Order = 186
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812691,
                        Latitude = 24.019654,
                        Order = 187
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81212,
                        Latitude = 24.0196,
                        Order = 188
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81209,
                        Latitude = 24.0196,
                        Order = 189
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81203,
                        Latitude = 24.01959,
                        Order = 190
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81175,
                        Latitude = 24.01957,
                        Order = 191
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81172,
                        Latitude = 24.01957,
                        Order = 192
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81161,
                        Latitude = 24.01955,
                        Order = 193
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81148,
                        Latitude = 24.01954,
                        Order = 194
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81125,
                        Latitude = 24.01952,
                        Order = 195
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81103,
                        Latitude = 24.0195,
                        Order = 196
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81051,
                        Latitude = 24.01944,
                        Order = 197
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81002,
                        Latitude = 24.01939,
                        Order = 198
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8097,
                        Latitude = 24.01935,
                        Order = 199
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80871,
                        Latitude = 24.01925,
                        Order = 200
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.808485,
                        Latitude = 24.019219,
                        Order = 201
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80828,
                        Latitude = 24.01919,
                        Order = 202
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.808135,
                        Latitude = 24.01918,
                        Order = 203
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80815,
                        Latitude = 24.01875,
                        Order = 204
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80821,
                        Latitude = 24.01752,
                        Order = 205
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.808239,
                        Latitude = 24.017009,
                        Order = 206
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.808239,
                        Latitude = 24.017009,
                        Order = 207
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80825,
                        Latitude = 24.01681,
                        Order = 208
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80828,
                        Latitude = 24.01633,
                        Order = 209
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80828,
                        Latitude = 24.01628,
                        Order = 210
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8083,
                        Latitude = 24.01598,
                        Order = 211
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80837,
                        Latitude = 24.01523,
                        Order = 212
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80853,
                        Latitude = 24.01425,
                        Order = 213
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80858,
                        Latitude = 24.01393,
                        Order = 214
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80865,
                        Latitude = 24.0135,
                        Order = 215
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80877,
                        Latitude = 24.01288,
                        Order = 216
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80892,
                        Latitude = 24.012074,
                        Order = 217
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80896,
                        Latitude = 24.01186,
                        Order = 218
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80897,
                        Latitude = 24.0118,
                        Order = 219
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80931,
                        Latitude = 24.01021,
                        Order = 220
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80939,
                        Latitude = 24.00987,
                        Order = 221
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80951,
                        Latitude = 24.00924,
                        Order = 222
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.809631,
                        Latitude = 24.0087,
                        Order = 223
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80974,
                        Latitude = 24.00821,
                        Order = 224
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.809779,
                        Latitude = 24.008031,
                        Order = 225
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80987,
                        Latitude = 24.00754,
                        Order = 226
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80989,
                        Latitude = 24.00736,
                        Order = 227
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.809891,
                        Latitude = 24.007354,
                        Order = 228
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.809891,
                        Latitude = 24.007354,
                        Order = 229
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80992,
                        Latitude = 24.00703,
                        Order = 230
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.80994,
                        Latitude = 24.00672,
                        Order = 231
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81002,
                        Latitude = 24.00515,
                        Order = 232
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810052,
                        Latitude = 24.004603,
                        Order = 233
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81008,
                        Latitude = 24.00411,
                        Order = 234
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81008,
                        Latitude = 24.00397,
                        Order = 235
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81016,
                        Latitude = 24.00238,
                        Order = 236
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810276,
                        Latitude = 24.001215,
                        Order = 237
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810276,
                        Latitude = 24.001215,
                        Order = 238
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81032,
                        Latitude = 24.00077,
                        Order = 239
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810345,
                        Latitude = 24.000616,
                        Order = 240
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810527,
                        Latitude = 24.000195,
                        Order = 241
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810547,
                        Latitude = 24.000189,
                        Order = 242
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810573,
                        Latitude = 24.000173,
                        Order = 243
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8106,
                        Latitude = 24.000157,
                        Order = 244
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81063,
                        Latitude = 24.00012,
                        Order = 245
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81066,
                        Latitude = 24.00008,
                        Order = 246
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81068,
                        Latitude = 24.00004,
                        Order = 247
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8107,
                        Latitude = 24,
                        Order = 248
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81071,
                        Latitude = 23.99995,
                        Order = 249
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81073,
                        Latitude = 23.9999,
                        Order = 250
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81073,
                        Latitude = 23.99985,
                        Order = 251
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81074,
                        Latitude = 23.9998,
                        Order = 252
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81074,
                        Latitude = 23.99974,
                        Order = 253
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81073,
                        Latitude = 23.99969,
                        Order = 254
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81072,
                        Latitude = 23.99964,
                        Order = 255
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81071,
                        Latitude = 23.99959,
                        Order = 256
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810687,
                        Latitude = 23.999507,
                        Order = 257
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810661,
                        Latitude = 23.999467,
                        Order = 258
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81063,
                        Latitude = 23.999419,
                        Order = 259
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810508,
                        Latitude = 23.998824,
                        Order = 260
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810583,
                        Latitude = 23.998153,
                        Order = 261
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81063,
                        Latitude = 23.99773,
                        Order = 262
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81065,
                        Latitude = 23.99751,
                        Order = 263
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81067,
                        Latitude = 23.9973,
                        Order = 264
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81068,
                        Latitude = 23.99715,
                        Order = 265
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810723,
                        Latitude = 23.996742,
                        Order = 266
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.810723,
                        Latitude = 23.996742,
                        Order = 267
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81085,
                        Latitude = 23.99553,
                        Order = 268
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81099,
                        Latitude = 23.99421,
                        Order = 269
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81101,
                        Latitude = 23.99393,
                        Order = 270
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81102,
                        Latitude = 23.99382,
                        Order = 271
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81104,
                        Latitude = 23.99365,
                        Order = 272
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81111,
                        Latitude = 23.99301,
                        Order = 273
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.811243,
                        Latitude = 23.991693,
                        Order = 274
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81125,
                        Latitude = 23.99162,
                        Order = 275
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8113,
                        Latitude = 23.9912,
                        Order = 276
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81131,
                        Latitude = 23.99105,
                        Order = 277
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81134,
                        Latitude = 23.99076,
                        Order = 278
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.811385,
                        Latitude = 23.990265,
                        Order = 279
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.811385,
                        Latitude = 23.990265,
                        Order = 280
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8114,
                        Latitude = 23.9901,
                        Order = 281
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81144,
                        Latitude = 23.98985,
                        Order = 282
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81146,
                        Latitude = 23.98953,
                        Order = 283
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.811495,
                        Latitude = 23.989258,
                        Order = 284
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81152,
                        Latitude = 23.98893,
                        Order = 285
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81156,
                        Latitude = 23.98858,
                        Order = 286
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81167,
                        Latitude = 23.98743,
                        Order = 287
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81171,
                        Latitude = 23.98704,
                        Order = 288
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81181,
                        Latitude = 23.98603,
                        Order = 289
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81182,
                        Latitude = 23.9859,
                        Order = 290
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81186,
                        Latitude = 23.98552,
                        Order = 291
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81189,
                        Latitude = 23.98524,
                        Order = 292
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8119,
                        Latitude = 23.985178,
                        Order = 293
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81194,
                        Latitude = 23.98507,
                        Order = 294
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812,
                        Latitude = 23.98494,
                        Order = 295
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81212,
                        Latitude = 23.98471,
                        Order = 296
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812186,
                        Latitude = 23.984509,
                        Order = 297
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812302,
                        Latitude = 23.984402,
                        Order = 298
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81232,
                        Latitude = 23.98434,
                        Order = 299
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81234,
                        Latitude = 23.98428,
                        Order = 300
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81235,
                        Latitude = 23.98423,
                        Order = 301
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81236,
                        Latitude = 23.98419,
                        Order = 302
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81237,
                        Latitude = 23.98413,
                        Order = 303
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81238,
                        Latitude = 23.98407,
                        Order = 304
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81238,
                        Latitude = 23.984,
                        Order = 305
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812368,
                        Latitude = 23.983841,
                        Order = 306
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81234,
                        Latitude = 23.9838,
                        Order = 307
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81233,
                        Latitude = 23.98376,
                        Order = 308
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81231,
                        Latitude = 23.98371,
                        Order = 309
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81229,
                        Latitude = 23.98367,
                        Order = 310
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812278,
                        Latitude = 23.983602,
                        Order = 311
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81221,
                        Latitude = 23.98334,
                        Order = 312
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81218,
                        Latitude = 23.9832,
                        Order = 313
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812157,
                        Latitude = 23.983041,
                        Order = 314
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81218,
                        Latitude = 23.98271,
                        Order = 315
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81222,
                        Latitude = 23.98232,
                        Order = 316
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81222,
                        Latitude = 23.98226,
                        Order = 317
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812235,
                        Latitude = 23.982113,
                        Order = 318
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.812235,
                        Latitude = 23.982113,
                        Order = 319
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81228,
                        Latitude = 23.98169,
                        Order = 320
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81239,
                        Latitude = 23.98098,
                        Order = 321
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81249,
                        Latitude = 23.98032,
                        Order = 322
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81267,
                        Latitude = 23.97946,
                        Order = 323
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81287,
                        Latitude = 23.97864,
                        Order = 324
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81298,
                        Latitude = 23.97832,
                        Order = 325
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81302,
                        Latitude = 23.97819,
                        Order = 326
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813058,
                        Latitude = 23.978102,
                        Order = 327
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81318,
                        Latitude = 23.97778,
                        Order = 328
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81333,
                        Latitude = 23.97746,
                        Order = 329
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81338,
                        Latitude = 23.97737,
                        Order = 330
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813644,
                        Latitude = 23.976825,
                        Order = 331
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813644,
                        Latitude = 23.976825,
                        Order = 332
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81385,
                        Latitude = 23.9764,
                        Order = 333
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.813947,
                        Latitude = 23.97624,
                        Order = 334
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81458,
                        Latitude = 23.97522,
                        Order = 335
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81517,
                        Latitude = 23.97427,
                        Order = 336
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81529,
                        Latitude = 23.97406,
                        Order = 337
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81531,
                        Latitude = 23.97403,
                        Order = 338
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81551,
                        Latitude = 23.97374,
                        Order = 339
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81577,
                        Latitude = 23.97339,
                        Order = 340
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81599,
                        Latitude = 23.97307,
                        Order = 341
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81607,
                        Latitude = 23.97297,
                        Order = 342
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81641,
                        Latitude = 23.9726,
                        Order = 343
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81658,
                        Latitude = 23.97245,
                        Order = 344
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.816644,
                        Latitude = 23.972389,
                        Order = 345
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.816644,
                        Latitude = 23.972389,
                        Order = 346
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81679,
                        Latitude = 23.97225,
                        Order = 347
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8171,
                        Latitude = 23.97198,
                        Order = 348
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.817131,
                        Latitude = 23.971953,
                        Order = 349
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.817181,
                        Latitude = 23.971854,
                        Order = 350
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.817192,
                        Latitude = 23.971827,
                        Order = 351
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.817409,
                        Latitude = 23.971648,
                        Order = 352
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81891,
                        Latitude = 23.97041,
                        Order = 353
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.819576,
                        Latitude = 23.969861,
                        Order = 354
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.819576,
                        Latitude = 23.969861,
                        Order = 355
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.81993,
                        Latitude = 23.96957,
                        Order = 356
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.820043,
                        Latitude = 23.969477,
                        Order = 357
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.820659,
                        Latitude = 23.968971,
                        Order = 358
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82079,
                        Latitude = 23.96933,
                        Order = 359
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.820931,
                        Latitude = 23.969739,
                        Order = 360
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.820931,
                        Latitude = 23.969739,
                        Order = 361
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82135,
                        Latitude = 23.97095,
                        Order = 362
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82153,
                        Latitude = 23.97145,
                        Order = 363
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82169,
                        Latitude = 23.97191,
                        Order = 364
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82197,
                        Latitude = 23.97265,
                        Order = 365
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.822091,
                        Latitude = 23.972959,
                        Order = 366
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82221,
                        Latitude = 23.97326,
                        Order = 367
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82236,
                        Latitude = 23.97365,
                        Order = 368
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82246,
                        Latitude = 23.97387,
                        Order = 369
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82258,
                        Latitude = 23.97415,
                        Order = 370
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82269,
                        Latitude = 23.97439,
                        Order = 371
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.822704,
                        Latitude = 23.974418,
                        Order = 372
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.822704,
                        Latitude = 23.974418,
                        Order = 373
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82275,
                        Latitude = 23.97451,
                        Order = 374
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82287,
                        Latitude = 23.97477,
                        Order = 375
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82307,
                        Latitude = 23.97517,
                        Order = 376
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8233,
                        Latitude = 23.97566,
                        Order = 377
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8235,
                        Latitude = 23.97608,
                        Order = 378
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.823865,
                        Latitude = 23.976855,
                        Order = 379
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82391,
                        Latitude = 23.97695,
                        Order = 380
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.824085,
                        Latitude = 23.977319,
                        Order = 381
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82425,
                        Latitude = 23.97764,
                        Order = 382
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82433,
                        Latitude = 23.9778,
                        Order = 383
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82473,
                        Latitude = 23.97854,
                        Order = 384
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82479,
                        Latitude = 23.97863,
                        Order = 385
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.824986,
                        Latitude = 23.979006,
                        Order = 386
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.824986,
                        Latitude = 23.979006,
                        Order = 387
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82502,
                        Latitude = 23.97907,
                        Order = 388
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82513,
                        Latitude = 23.97927,
                        Order = 389
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82602,
                        Latitude = 23.98091,
                        Order = 390
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82605,
                        Latitude = 23.98097,
                        Order = 391
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82617,
                        Latitude = 23.98119,
                        Order = 392
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82621,
                        Latitude = 23.98126,
                        Order = 393
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82625,
                        Latitude = 23.98134,
                        Order = 394
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82631,
                        Latitude = 23.98144,
                        Order = 395
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82655,
                        Latitude = 23.98184,
                        Order = 396
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82663,
                        Latitude = 23.98197,
                        Order = 397
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.826887,
                        Latitude = 23.982421,
                        Order = 398
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.827083,
                        Latitude = 23.982778,
                        Order = 399
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.827567,
                        Latitude = 23.982145,
                        Order = 400
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.827567,
                        Latitude = 23.982145,
                        Order = 401
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82767,
                        Latitude = 23.98201,
                        Order = 402
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8286,
                        Latitude = 23.98092,
                        Order = 403
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82928,
                        Latitude = 23.98012,
                        Order = 404
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.82973,
                        Latitude = 23.97965,
                        Order = 405
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.829898,
                        Latitude = 23.979576,
                        Order = 406
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.832368,
                        Latitude = 23.978176,
                        Order = 407
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.832439,
                        Latitude = 23.978575,
                        Order = 408
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.832539,
                        Latitude = 23.979135,
                        Order = 409
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.832539,
                        Latitude = 23.979135,
                        Order = 410
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.832673,
                        Latitude = 23.97989,
                        Order = 411
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8328,
                        Latitude = 23.98053,
                        Order = 412
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83296,
                        Latitude = 23.9815,
                        Order = 413
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.833055,
                        Latitude = 23.982015,
                        Order = 414
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83323,
                        Latitude = 23.98297,
                        Order = 415
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.833331,
                        Latitude = 23.983497,
                        Order = 416
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83336,
                        Latitude = 23.983646,
                        Order = 417
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.833409,
                        Latitude = 23.983912,
                        Order = 418
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.833518,
                        Latitude = 23.984519,
                        Order = 419
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.833518,
                        Latitude = 23.984519,
                        Order = 420
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83356,
                        Latitude = 23.98475,
                        Order = 421
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.833655,
                        Latitude = 23.985286,
                        Order = 422
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83387,
                        Latitude = 23.9865,
                        Order = 423
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83397,
                        Latitude = 23.98703,
                        Order = 424
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83413,
                        Latitude = 23.98787,
                        Order = 425
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83427,
                        Latitude = 23.98862,
                        Order = 426
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834478,
                        Latitude = 23.98987,
                        Order = 427
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834505,
                        Latitude = 23.990035,
                        Order = 428
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834505,
                        Latitude = 23.990035,
                        Order = 429
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834635,
                        Latitude = 23.990817,
                        Order = 430
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834644,
                        Latitude = 23.990869,
                        Order = 431
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834648,
                        Latitude = 23.990889,
                        Order = 432
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834708,
                        Latitude = 23.991147,
                        Order = 433
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834773,
                        Latitude = 23.991514,
                        Order = 434
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834856,
                        Latitude = 23.991984,
                        Order = 435
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834903,
                        Latitude = 23.992248,
                        Order = 436
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.834973,
                        Latitude = 23.99264,
                        Order = 437
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.835044,
                        Latitude = 23.993032,
                        Order = 438
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.835138,
                        Latitude = 23.993595,
                        Order = 439
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.835192,
                        Latitude = 23.99392,
                        Order = 440
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83526,
                        Latitude = 23.99425,
                        Order = 441
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83537,
                        Latitude = 23.9949,
                        Order = 442
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83537,
                        Latitude = 23.9949,
                        Order = 443
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.835508,
                        Latitude = 23.995717,
                        Order = 444
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83566,
                        Latitude = 23.99653,
                        Order = 445
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83587,
                        Latitude = 23.99761,
                        Order = 446
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.835999,
                        Latitude = 23.998345,
                        Order = 447
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83602,
                        Latitude = 23.99848,
                        Order = 448
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8361,
                        Latitude = 23.99891,
                        Order = 449
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836178,
                        Latitude = 23.999351,
                        Order = 450
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836178,
                        Latitude = 23.999351,
                        Order = 451
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83636,
                        Latitude = 24.00038,
                        Order = 452
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83646,
                        Latitude = 24.00096,
                        Order = 453
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836665,
                        Latitude = 24.002043,
                        Order = 454
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836717,
                        Latitude = 24.002348,
                        Order = 455
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83675,
                        Latitude = 24.00237,
                        Order = 456
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83676,
                        Latitude = 24.00238,
                        Order = 457
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83677,
                        Latitude = 24.00239,
                        Order = 458
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83678,
                        Latitude = 24.00239,
                        Order = 459
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8369,
                        Latitude = 24.00248,
                        Order = 460
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.836948,
                        Latitude = 24.002515,
                        Order = 461
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83703,
                        Latitude = 24.00246,
                        Order = 462
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.837137,
                        Latitude = 24.00237,
                        Order = 463
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83714,
                        Latitude = 24.00231,
                        Order = 464
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83716,
                        Latitude = 24.00221,
                        Order = 465
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83716,
                        Latitude = 24.00212,
                        Order = 466
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.837138,
                        Latitude = 24.001963,
                        Order = 467
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.837082,
                        Latitude = 24.0019,
                        Order = 468
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.837076,
                        Latitude = 24.001783,
                        Order = 469
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.837079,
                        Latitude = 24.001678,
                        Order = 470
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.837105,
                        Latitude = 24.001592,
                        Order = 471
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83712,
                        Latitude = 24.00157,
                        Order = 472
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83717,
                        Latitude = 24.00144,
                        Order = 473
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.837575,
                        Latitude = 24.0004,
                        Order = 474
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83764,
                        Latitude = 24.00028,
                        Order = 475
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.837676,
                        Latitude = 24.000188,
                        Order = 476
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.837676,
                        Latitude = 24.000188,
                        Order = 477
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.838008,
                        Latitude = 23.999348,
                        Order = 478
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.838086,
                        Latitude = 23.999127,
                        Order = 479
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.838361,
                        Latitude = 23.998347,
                        Order = 480
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.838374,
                        Latitude = 23.998309,
                        Order = 481
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.838418,
                        Latitude = 23.998178,
                        Order = 482
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.838804,
                        Latitude = 23.997043,
                        Order = 483
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.838933,
                        Latitude = 23.996731,
                        Order = 484
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83917,
                        Latitude = 23.99616,
                        Order = 485
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.839219,
                        Latitude = 23.996021,
                        Order = 486
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.839267,
                        Latitude = 23.995967,
                        Order = 487
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.839335,
                        Latitude = 23.995945,
                        Order = 488
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.839437,
                        Latitude = 23.995968,
                        Order = 489
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.839682,
                        Latitude = 23.996145,
                        Order = 490
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.839748,
                        Latitude = 23.996189,
                        Order = 491
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.8398,
                        Latitude = 23.99619,
                        Order = 492
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83983,
                        Latitude = 23.99618,
                        Order = 493
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.83988,
                        Latitude = 23.99615,
                        Order = 494
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.839909,
                        Latitude = 23.996134,
                        Order = 495
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.839947,
                        Latitude = 23.996103,
                        Order = 496
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.840039,
                        Latitude = 23.996,
                        Order = 497
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.840123,
                        Latitude = 23.995908,
                        Order = 498
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.840199,
                        Latitude = 23.995804,
                        Order = 499
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.840213,
                        Latitude = 23.995737,
                        Order = 500
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.84023,
                        Latitude = 23.995611,
                        Order = 501
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.84018,
                        Latitude = 23.995502,
                        Order = 502
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.840165,
                        Latitude = 23.99547,
                        Order = 503
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Forward,
                        Longitude = 49.839834,
                        Latitude = 23.995251,
                        Order = 504
                    }
                };
                var backward16Points = new List<RoutePoint>
                {
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.839834,
                        Latitude = 23.995251,
                        Order = 1
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.839689,
                        Latitude = 23.995155,
                        Order = 2
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83963,
                        Latitude = 23.995148,
                        Order = 3
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.839613,
                        Latitude = 23.995147,
                        Order = 4
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.839526,
                        Latitude = 23.99521,
                        Order = 5
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.839429,
                        Latitude = 23.995467,
                        Order = 6
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.839219,
                        Latitude = 23.996021,
                        Order = 7
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83917,
                        Latitude = 23.99616,
                        Order = 8
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838933,
                        Latitude = 23.996731,
                        Order = 9
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838804,
                        Latitude = 23.997043,
                        Order = 10
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838418,
                        Latitude = 23.998178,
                        Order = 11
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838374,
                        Latitude = 23.998309,
                        Order = 12
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838361,
                        Latitude = 23.998347,
                        Order = 13
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838086,
                        Latitude = 23.999127,
                        Order = 14
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838086,
                        Latitude = 23.999127,
                        Order = 15
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.838008,
                        Latitude = 23.999348,
                        Order = 16
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837676,
                        Latitude = 24.000188,
                        Order = 17
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83764,
                        Latitude = 24.00028,
                        Order = 18
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837575,
                        Latitude = 24.0004,
                        Order = 19
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83717,
                        Latitude = 24.00144,
                        Order = 20
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83712,
                        Latitude = 24.00157,
                        Order = 21
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837105,
                        Latitude = 24.001592,
                        Order = 22
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837066,
                        Latitude = 24.001662,
                        Order = 23
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837037,
                        Latitude = 24.001697,
                        Order = 24
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.837009,
                        Latitude = 24.001722,
                        Order = 25
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836981,
                        Latitude = 24.001738,
                        Order = 26
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836949,
                        Latitude = 24.001749,
                        Order = 27
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836902,
                        Latitude = 24.001747,
                        Order = 28
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836818,
                        Latitude = 24.001748,
                        Order = 29
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836711,
                        Latitude = 24.001267,
                        Order = 30
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83652,
                        Latitude = 24.00032,
                        Order = 31
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836356,
                        Latitude = 23.999387,
                        Order = 32
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836356,
                        Latitude = 23.999387,
                        Order = 33
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.836161,
                        Latitude = 23.998277,
                        Order = 34
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83613,
                        Latitude = 23.998098,
                        Order = 35
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83591,
                        Latitude = 23.99689,
                        Order = 36
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.835679,
                        Latitude = 23.995668,
                        Order = 37
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.835508,
                        Latitude = 23.994763,
                        Order = 38
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.835508,
                        Latitude = 23.994763,
                        Order = 39
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83546,
                        Latitude = 23.99451,
                        Order = 40
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83546,
                        Latitude = 23.99439,
                        Order = 41
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83545,
                        Latitude = 23.99415,
                        Order = 42
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83545,
                        Latitude = 23.99362,
                        Order = 43
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8355,
                        Latitude = 23.99262,
                        Order = 44
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83552,
                        Latitude = 23.99192,
                        Order = 45
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83552,
                        Latitude = 23.99161,
                        Order = 46
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83551,
                        Latitude = 23.99137,
                        Order = 47
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83548,
                        Latitude = 23.9912,
                        Order = 48
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83545,
                        Latitude = 23.99109,
                        Order = 49
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83542,
                        Latitude = 23.99098,
                        Order = 50
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83536,
                        Latitude = 23.99083,
                        Order = 51
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83533,
                        Latitude = 23.99076,
                        Order = 52
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8353,
                        Latitude = 23.99073,
                        Order = 53
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83527,
                        Latitude = 23.9907,
                        Order = 54
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83524,
                        Latitude = 23.99067,
                        Order = 55
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8352,
                        Latitude = 23.99065,
                        Order = 56
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83516,
                        Latitude = 23.99063,
                        Order = 57
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83511,
                        Latitude = 23.99062,
                        Order = 58
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83506,
                        Latitude = 23.99062,
                        Order = 59
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.835,
                        Latitude = 23.99064,
                        Order = 60
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83493,
                        Latitude = 23.99066,
                        Order = 61
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83482,
                        Latitude = 23.99071,
                        Order = 62
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.834635,
                        Latitude = 23.990817,
                        Order = 63
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.834505,
                        Latitude = 23.990035,
                        Order = 64
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.834478,
                        Latitude = 23.98987,
                        Order = 65
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.834478,
                        Latitude = 23.98987,
                        Order = 66
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83427,
                        Latitude = 23.98862,
                        Order = 67
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83413,
                        Latitude = 23.98787,
                        Order = 68
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83397,
                        Latitude = 23.98703,
                        Order = 69
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83387,
                        Latitude = 23.9865,
                        Order = 70
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.833655,
                        Latitude = 23.985286,
                        Order = 71
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.833655,
                        Latitude = 23.985286,
                        Order = 72
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83356,
                        Latitude = 23.98475,
                        Order = 73
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.833518,
                        Latitude = 23.984519,
                        Order = 74
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.833409,
                        Latitude = 23.983912,
                        Order = 75
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83289,
                        Latitude = 23.98412,
                        Order = 76
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8321,
                        Latitude = 23.98444,
                        Order = 77
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8315,
                        Latitude = 23.98471,
                        Order = 78
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83138,
                        Latitude = 23.98477,
                        Order = 79
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83131,
                        Latitude = 23.98485,
                        Order = 80
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.83118,
                        Latitude = 23.98501,
                        Order = 81
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.829367,
                        Latitude = 23.98743,
                        Order = 82
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.829317,
                        Latitude = 23.98753,
                        Order = 83
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.829273,
                        Latitude = 23.987644,
                        Order = 84
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.829123,
                        Latitude = 23.987329,
                        Order = 85
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.829123,
                        Latitude = 23.987329,
                        Order = 86
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82856,
                        Latitude = 23.98615,
                        Order = 87
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82816,
                        Latitude = 23.98533,
                        Order = 88
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.827812,
                        Latitude = 23.984402,
                        Order = 89
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8275,
                        Latitude = 23.98359,
                        Order = 90
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82736,
                        Latitude = 23.98333,
                        Order = 91
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82735,
                        Latitude = 23.98331,
                        Order = 92
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.827311,
                        Latitude = 23.983232,
                        Order = 93
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.827311,
                        Latitude = 23.983232,
                        Order = 94
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.827083,
                        Latitude = 23.982778,
                        Order = 95
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.826887,
                        Latitude = 23.982421,
                        Order = 96
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82663,
                        Latitude = 23.98197,
                        Order = 97
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82655,
                        Latitude = 23.98184,
                        Order = 98
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82631,
                        Latitude = 23.98144,
                        Order = 99
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82625,
                        Latitude = 23.98134,
                        Order = 100
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82621,
                        Latitude = 23.98126,
                        Order = 101
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82617,
                        Latitude = 23.98119,
                        Order = 102
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82605,
                        Latitude = 23.98097,
                        Order = 103
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82602,
                        Latitude = 23.98091,
                        Order = 104
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82513,
                        Latitude = 23.97927,
                        Order = 105
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82502,
                        Latitude = 23.97907,
                        Order = 106
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.824986,
                        Latitude = 23.979006,
                        Order = 107
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82479,
                        Latitude = 23.97863,
                        Order = 108
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82473,
                        Latitude = 23.97854,
                        Order = 109
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82433,
                        Latitude = 23.9778,
                        Order = 110
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82425,
                        Latitude = 23.97764,
                        Order = 111
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.824085,
                        Latitude = 23.977319,
                        Order = 112
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82391,
                        Latitude = 23.97695,
                        Order = 113
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.823865,
                        Latitude = 23.976855,
                        Order = 114
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.823865,
                        Latitude = 23.976855,
                        Order = 115
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8235,
                        Latitude = 23.97608,
                        Order = 116
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8233,
                        Latitude = 23.97566,
                        Order = 117
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82307,
                        Latitude = 23.97517,
                        Order = 118
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82287,
                        Latitude = 23.97477,
                        Order = 119
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82275,
                        Latitude = 23.97451,
                        Order = 120
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.822704,
                        Latitude = 23.974418,
                        Order = 121
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82269,
                        Latitude = 23.97439,
                        Order = 122
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82258,
                        Latitude = 23.97415,
                        Order = 123
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82246,
                        Latitude = 23.97387,
                        Order = 124
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82236,
                        Latitude = 23.97365,
                        Order = 125
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82221,
                        Latitude = 23.97326,
                        Order = 126
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.822091,
                        Latitude = 23.972959,
                        Order = 127
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.822091,
                        Latitude = 23.972959,
                        Order = 128
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82197,
                        Latitude = 23.97265,
                        Order = 129
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82169,
                        Latitude = 23.97191,
                        Order = 130
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82153,
                        Latitude = 23.97145,
                        Order = 131
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82135,
                        Latitude = 23.97095,
                        Order = 132
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.820931,
                        Latitude = 23.969739,
                        Order = 133
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.82079,
                        Latitude = 23.96933,
                        Order = 134
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.820659,
                        Latitude = 23.968971,
                        Order = 135
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.820043,
                        Latitude = 23.969477,
                        Order = 136
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.820043,
                        Latitude = 23.969477,
                        Order = 137
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81993,
                        Latitude = 23.96957,
                        Order = 138
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.819576,
                        Latitude = 23.969861,
                        Order = 139
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81891,
                        Latitude = 23.97041,
                        Order = 140
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.817409,
                        Latitude = 23.971648,
                        Order = 141
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.817409,
                        Latitude = 23.971648,
                        Order = 142
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.817192,
                        Latitude = 23.971827,
                        Order = 143
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.817109,
                        Latitude = 23.971861,
                        Order = 144
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81704,
                        Latitude = 23.97194,
                        Order = 145
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81671,
                        Latitude = 23.97222,
                        Order = 146
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81635,
                        Latitude = 23.97254,
                        Order = 147
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81616,
                        Latitude = 23.97274,
                        Order = 148
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81583,
                        Latitude = 23.97315,
                        Order = 149
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81569,
                        Latitude = 23.97334,
                        Order = 150
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81555,
                        Latitude = 23.97354,
                        Order = 151
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81524,
                        Latitude = 23.97403,
                        Order = 152
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.814422,
                        Latitude = 23.975342,
                        Order = 153
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.814422,
                        Latitude = 23.975342,
                        Order = 154
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813904,
                        Latitude = 23.976174,
                        Order = 155
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813723,
                        Latitude = 23.9765,
                        Order = 156
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813627,
                        Latitude = 23.976677,
                        Order = 157
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813567,
                        Latitude = 23.976795,
                        Order = 158
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813496,
                        Latitude = 23.976933,
                        Order = 159
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81332,
                        Latitude = 23.9773,
                        Order = 160
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81313,
                        Latitude = 23.97774,
                        Order = 161
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813013,
                        Latitude = 23.978064,
                        Order = 162
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81294,
                        Latitude = 23.97829,
                        Order = 163
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8127,
                        Latitude = 23.97909,
                        Order = 164
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81257,
                        Latitude = 23.97964,
                        Order = 165
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81244,
                        Latitude = 23.98027,
                        Order = 166
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81233,
                        Latitude = 23.98096,
                        Order = 167
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81228,
                        Latitude = 23.98136,
                        Order = 168
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81224,
                        Latitude = 23.98154,
                        Order = 169
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81222,
                        Latitude = 23.98166,
                        Order = 170
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.812179,
                        Latitude = 23.982141,
                        Order = 171
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.812179,
                        Latitude = 23.982141,
                        Order = 172
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81217,
                        Latitude = 23.98225,
                        Order = 173
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.812098,
                        Latitude = 23.982694,
                        Order = 174
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81204,
                        Latitude = 23.98302,
                        Order = 175
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81202,
                        Latitude = 23.98313,
                        Order = 176
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811869,
                        Latitude = 23.983485,
                        Order = 177
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811838,
                        Latitude = 23.983525,
                        Order = 178
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811782,
                        Latitude = 23.9836,
                        Order = 179
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81176,
                        Latitude = 23.98365,
                        Order = 180
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81173,
                        Latitude = 23.98372,
                        Order = 181
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8117,
                        Latitude = 23.98379,
                        Order = 182
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81168,
                        Latitude = 23.98385,
                        Order = 183
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81168,
                        Latitude = 23.98386,
                        Order = 184
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81167,
                        Latitude = 23.98393,
                        Order = 185
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81167,
                        Latitude = 23.98401,
                        Order = 186
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811672,
                        Latitude = 23.984145,
                        Order = 187
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8117,
                        Latitude = 23.98424,
                        Order = 188
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81172,
                        Latitude = 23.9843,
                        Order = 189
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81174,
                        Latitude = 23.98435,
                        Order = 190
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811785,
                        Latitude = 23.984455,
                        Order = 191
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81186,
                        Latitude = 23.98491,
                        Order = 192
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8119,
                        Latitude = 23.985178,
                        Order = 193
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81189,
                        Latitude = 23.98524,
                        Order = 194
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81186,
                        Latitude = 23.98552,
                        Order = 195
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81182,
                        Latitude = 23.9859,
                        Order = 196
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81181,
                        Latitude = 23.98603,
                        Order = 197
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81171,
                        Latitude = 23.98704,
                        Order = 198
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81167,
                        Latitude = 23.98743,
                        Order = 199
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81156,
                        Latitude = 23.98858,
                        Order = 200
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81152,
                        Latitude = 23.98893,
                        Order = 201
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811495,
                        Latitude = 23.989258,
                        Order = 202
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81146,
                        Latitude = 23.98953,
                        Order = 203
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81144,
                        Latitude = 23.98985,
                        Order = 204
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8114,
                        Latitude = 23.9901,
                        Order = 205
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811385,
                        Latitude = 23.990265,
                        Order = 206
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81134,
                        Latitude = 23.99076,
                        Order = 207
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81131,
                        Latitude = 23.99105,
                        Order = 208
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8113,
                        Latitude = 23.9912,
                        Order = 209
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81125,
                        Latitude = 23.99162,
                        Order = 210
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811243,
                        Latitude = 23.991693,
                        Order = 211
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811243,
                        Latitude = 23.991693,
                        Order = 212
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81111,
                        Latitude = 23.99301,
                        Order = 213
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81104,
                        Latitude = 23.99365,
                        Order = 214
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81102,
                        Latitude = 23.99382,
                        Order = 215
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81101,
                        Latitude = 23.99393,
                        Order = 216
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81099,
                        Latitude = 23.99421,
                        Order = 217
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81085,
                        Latitude = 23.99553,
                        Order = 218
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810723,
                        Latitude = 23.996742,
                        Order = 219
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81068,
                        Latitude = 23.99715,
                        Order = 220
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81067,
                        Latitude = 23.9973,
                        Order = 221
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81065,
                        Latitude = 23.99751,
                        Order = 222
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81063,
                        Latitude = 23.99773,
                        Order = 223
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810583,
                        Latitude = 23.998153,
                        Order = 224
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810583,
                        Latitude = 23.998153,
                        Order = 225
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810508,
                        Latitude = 23.998824,
                        Order = 226
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810444,
                        Latitude = 23.99895,
                        Order = 227
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810382,
                        Latitude = 23.999089,
                        Order = 228
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810329,
                        Latitude = 23.999198,
                        Order = 229
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810277,
                        Latitude = 23.999341,
                        Order = 230
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81027,
                        Latitude = 23.99935,
                        Order = 231
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81026,
                        Latitude = 23.99936,
                        Order = 232
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81024,
                        Latitude = 23.99937,
                        Order = 233
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81023,
                        Latitude = 23.99939,
                        Order = 234
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81022,
                        Latitude = 23.9994,
                        Order = 235
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81021,
                        Latitude = 23.99942,
                        Order = 236
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8102,
                        Latitude = 23.99943,
                        Order = 237
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81019,
                        Latitude = 23.999452,
                        Order = 238
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81017,
                        Latitude = 23.9995,
                        Order = 239
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81014,
                        Latitude = 23.99955,
                        Order = 240
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81013,
                        Latitude = 23.99961,
                        Order = 241
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81012,
                        Latitude = 23.99967,
                        Order = 242
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81011,
                        Latitude = 23.99973,
                        Order = 243
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81011,
                        Latitude = 23.99979,
                        Order = 244
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81012,
                        Latitude = 23.99986,
                        Order = 245
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81013,
                        Latitude = 23.99992,
                        Order = 246
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810156,
                        Latitude = 23.999999,
                        Order = 247
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810179,
                        Latitude = 24.000044,
                        Order = 248
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810206,
                        Latitude = 24.000088,
                        Order = 249
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810241,
                        Latitude = 24.00013,
                        Order = 250
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81027,
                        Latitude = 24.00025,
                        Order = 251
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81031,
                        Latitude = 24.00041,
                        Order = 252
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810345,
                        Latitude = 24.000616,
                        Order = 253
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81032,
                        Latitude = 24.00077,
                        Order = 254
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810276,
                        Latitude = 24.001215,
                        Order = 255
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81016,
                        Latitude = 24.00238,
                        Order = 256
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81008,
                        Latitude = 24.00397,
                        Order = 257
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81008,
                        Latitude = 24.00411,
                        Order = 258
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810052,
                        Latitude = 24.004603,
                        Order = 259
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810052,
                        Latitude = 24.004603,
                        Order = 260
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81002,
                        Latitude = 24.00515,
                        Order = 261
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80994,
                        Latitude = 24.00672,
                        Order = 262
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80992,
                        Latitude = 24.00703,
                        Order = 263
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.809891,
                        Latitude = 24.007354,
                        Order = 264
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80989,
                        Latitude = 24.00736,
                        Order = 265
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80987,
                        Latitude = 24.00754,
                        Order = 266
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.809779,
                        Latitude = 24.008031,
                        Order = 267
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80974,
                        Latitude = 24.00821,
                        Order = 268
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.809631,
                        Latitude = 24.0087,
                        Order = 269
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.809631,
                        Latitude = 24.0087,
                        Order = 270
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80951,
                        Latitude = 24.00924,
                        Order = 271
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80939,
                        Latitude = 24.00987,
                        Order = 272
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80931,
                        Latitude = 24.01021,
                        Order = 273
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80897,
                        Latitude = 24.0118,
                        Order = 274
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80896,
                        Latitude = 24.01186,
                        Order = 275
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80892,
                        Latitude = 24.012074,
                        Order = 276
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80892,
                        Latitude = 24.012074,
                        Order = 277
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80877,
                        Latitude = 24.01288,
                        Order = 278
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80865,
                        Latitude = 24.0135,
                        Order = 279
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80858,
                        Latitude = 24.01393,
                        Order = 280
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80853,
                        Latitude = 24.01425,
                        Order = 281
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80837,
                        Latitude = 24.01523,
                        Order = 282
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8083,
                        Latitude = 24.01598,
                        Order = 283
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80828,
                        Latitude = 24.01628,
                        Order = 284
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80828,
                        Latitude = 24.01633,
                        Order = 285
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80825,
                        Latitude = 24.01681,
                        Order = 286
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.808239,
                        Latitude = 24.017009,
                        Order = 287
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80821,
                        Latitude = 24.01752,
                        Order = 288
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80815,
                        Latitude = 24.01875,
                        Order = 289
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.808135,
                        Latitude = 24.01918,
                        Order = 290
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80828,
                        Latitude = 24.01919,
                        Order = 291
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.808485,
                        Latitude = 24.019219,
                        Order = 292
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.808485,
                        Latitude = 24.019219,
                        Order = 293
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80871,
                        Latitude = 24.01925,
                        Order = 294
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8097,
                        Latitude = 24.01935,
                        Order = 295
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81002,
                        Latitude = 24.01939,
                        Order = 296
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81051,
                        Latitude = 24.01944,
                        Order = 297
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81103,
                        Latitude = 24.0195,
                        Order = 298
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81125,
                        Latitude = 24.01952,
                        Order = 299
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81148,
                        Latitude = 24.01954,
                        Order = 300
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81161,
                        Latitude = 24.01955,
                        Order = 301
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81172,
                        Latitude = 24.01957,
                        Order = 302
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81175,
                        Latitude = 24.01957,
                        Order = 303
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81203,
                        Latitude = 24.01959,
                        Order = 304
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81209,
                        Latitude = 24.0196,
                        Order = 305
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81212,
                        Latitude = 24.0196,
                        Order = 306
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.812691,
                        Latitude = 24.019654,
                        Order = 307
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81282,
                        Latitude = 24.01966,
                        Order = 308
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81322,
                        Latitude = 24.0197,
                        Order = 309
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81431,
                        Latitude = 24.01981,
                        Order = 310
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81449,
                        Latitude = 24.01983,
                        Order = 311
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.814652,
                        Latitude = 24.019849,
                        Order = 312
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.814645,
                        Latitude = 24.020459,
                        Order = 313
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.814645,
                        Latitude = 24.020459,
                        Order = 314
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81464,
                        Latitude = 24.02084,
                        Order = 315
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81462,
                        Latitude = 24.02127,
                        Order = 316
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81457,
                        Latitude = 24.02261,
                        Order = 317
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81456,
                        Latitude = 24.02269,
                        Order = 318
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.814546,
                        Latitude = 24.023079,
                        Order = 319
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81449,
                        Latitude = 24.02467,
                        Order = 320
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.814458,
                        Latitude = 24.0256,
                        Order = 321
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81524,
                        Latitude = 24.0257,
                        Order = 322
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81535,
                        Latitude = 24.02571,
                        Order = 323
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8155,
                        Latitude = 24.02574,
                        Order = 324
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81608,
                        Latitude = 24.02584,
                        Order = 325
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81615,
                        Latitude = 24.02586,
                        Order = 326
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.816667,
                        Latitude = 24.025941,
                        Order = 327
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81679,
                        Latitude = 24.02596,
                        Order = 328
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.816926,
                        Latitude = 24.025986,
                        Order = 329
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.816726,
                        Latitude = 24.02665,
                        Order = 330
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.816726,
                        Latitude = 24.02665,
                        Order = 331
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81669,
                        Latitude = 24.02677,
                        Order = 332
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81631,
                        Latitude = 24.02798,
                        Order = 333
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81603,
                        Latitude = 24.02891,
                        Order = 334
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81574,
                        Latitude = 24.0299,
                        Order = 335
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81571,
                        Latitude = 24.03001,
                        Order = 336
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.815627,
                        Latitude = 24.030267,
                        Order = 337
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.815614,
                        Latitude = 24.030306,
                        Order = 338
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.815614,
                        Latitude = 24.030306,
                        Order = 339
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81561,
                        Latitude = 24.03032,
                        Order = 340
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81502,
                        Latitude = 24.03214,
                        Order = 341
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81467,
                        Latitude = 24.03327,
                        Order = 342
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8146,
                        Latitude = 24.03355,
                        Order = 343
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.814354,
                        Latitude = 24.034322,
                        Order = 344
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81433,
                        Latitude = 24.03441,
                        Order = 345
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813963,
                        Latitude = 24.035567,
                        Order = 346
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81393,
                        Latitude = 24.03567,
                        Order = 347
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813878,
                        Latitude = 24.035832,
                        Order = 348
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813878,
                        Latitude = 24.035832,
                        Order = 349
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81373,
                        Latitude = 24.0363,
                        Order = 350
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813562,
                        Latitude = 24.036774,
                        Order = 351
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813506,
                        Latitude = 24.036904,
                        Order = 352
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813489,
                        Latitude = 24.036909,
                        Order = 353
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813473,
                        Latitude = 24.036915,
                        Order = 354
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813457,
                        Latitude = 24.036924,
                        Order = 355
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813443,
                        Latitude = 24.036935,
                        Order = 356
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81343,
                        Latitude = 24.036948,
                        Order = 357
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813418,
                        Latitude = 24.036964,
                        Order = 358
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813406,
                        Latitude = 24.036985,
                        Order = 359
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813397,
                        Latitude = 24.037003,
                        Order = 360
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813387,
                        Latitude = 24.037031,
                        Order = 361
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813381,
                        Latitude = 24.037058,
                        Order = 362
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813377,
                        Latitude = 24.037084,
                        Order = 363
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813375,
                        Latitude = 24.037137,
                        Order = 364
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813379,
                        Latitude = 24.037169,
                        Order = 365
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.813282,
                        Latitude = 24.037378,
                        Order = 366
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81311,
                        Latitude = 24.03779,
                        Order = 367
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.812979,
                        Latitude = 24.038189,
                        Order = 368
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.812979,
                        Latitude = 24.038189,
                        Order = 369
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81281,
                        Latitude = 24.0387,
                        Order = 370
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81268,
                        Latitude = 24.03903,
                        Order = 371
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81257,
                        Latitude = 24.03933,
                        Order = 372
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81241,
                        Latitude = 24.0398,
                        Order = 373
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81211,
                        Latitude = 24.04065,
                        Order = 374
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81195,
                        Latitude = 24.04115,
                        Order = 375
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.811779,
                        Latitude = 24.041604,
                        Order = 376
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81173,
                        Latitude = 24.04173,
                        Order = 377
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81164,
                        Latitude = 24.04197,
                        Order = 378
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81152,
                        Latitude = 24.04232,
                        Order = 379
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81142,
                        Latitude = 24.04262,
                        Order = 380
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81119,
                        Latitude = 24.04329,
                        Order = 381
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81092,
                        Latitude = 24.04411,
                        Order = 382
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81089,
                        Latitude = 24.0442,
                        Order = 383
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81089,
                        Latitude = 24.0442,
                        Order = 384
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810725,
                        Latitude = 24.044688,
                        Order = 385
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.81044,
                        Latitude = 24.04553,
                        Order = 386
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.810248,
                        Latitude = 24.046226,
                        Order = 387
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80998,
                        Latitude = 24.04631,
                        Order = 388
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80943,
                        Latitude = 24.04644,
                        Order = 389
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80888,
                        Latitude = 24.04657,
                        Order = 390
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80852,
                        Latitude = 24.04664,
                        Order = 391
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.808336,
                        Latitude = 24.04666,
                        Order = 392
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.807859,
                        Latitude = 24.046709,
                        Order = 393
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80761,
                        Latitude = 24.0467,
                        Order = 394
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8073,
                        Latitude = 24.04669,
                        Order = 395
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80689,
                        Latitude = 24.04663,
                        Order = 396
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80642,
                        Latitude = 24.04654,
                        Order = 397
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80639,
                        Latitude = 24.04654,
                        Order = 398
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80624,
                        Latitude = 24.04652,
                        Order = 399
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80598,
                        Latitude = 24.04648,
                        Order = 400
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80542,
                        Latitude = 24.04636,
                        Order = 401
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80505,
                        Latitude = 24.0463,
                        Order = 402
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80476,
                        Latitude = 24.04627,
                        Order = 403
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80418,
                        Latitude = 24.04617,
                        Order = 404
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80406,
                        Latitude = 24.04615,
                        Order = 405
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80397,
                        Latitude = 24.04615,
                        Order = 406
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.803789,
                        Latitude = 24.046117,
                        Order = 407
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80369,
                        Latitude = 24.04612,
                        Order = 408
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80365,
                        Latitude = 24.04612,
                        Order = 409
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80331,
                        Latitude = 24.04613,
                        Order = 410
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.803202,
                        Latitude = 24.046136,
                        Order = 411
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.803202,
                        Latitude = 24.046136,
                        Order = 412
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80297,
                        Latitude = 24.04615,
                        Order = 413
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80275,
                        Latitude = 24.04617,
                        Order = 414
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80249,
                        Latitude = 24.04621,
                        Order = 415
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80224,
                        Latitude = 24.04625,
                        Order = 416
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80221,
                        Latitude = 24.04625,
                        Order = 417
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80177,
                        Latitude = 24.04634,
                        Order = 418
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80174,
                        Latitude = 24.04635,
                        Order = 419
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80124,
                        Latitude = 24.04644,
                        Order = 420
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8009,
                        Latitude = 24.04654,
                        Order = 421
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8007,
                        Latitude = 24.0466,
                        Order = 422
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80056,
                        Latitude = 24.04667,
                        Order = 423
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.80049,
                        Latitude = 24.04672,
                        Order = 424
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.800271,
                        Latitude = 24.046864,
                        Order = 425
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.8001,
                        Latitude = 24.047,
                        Order = 426
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.7998,
                        Latitude = 24.04726,
                        Order = 427
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.799591,
                        Latitude = 24.047433,
                        Order = 428
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.799301,
                        Latitude = 24.047685,
                        Order = 429
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.7992,
                        Latitude = 24.04783,
                        Order = 430
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79897,
                        Latitude = 24.04819,
                        Order = 431
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79883,
                        Latitude = 24.04843,
                        Order = 432
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79866,
                        Latitude = 24.04877,
                        Order = 433
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79854,
                        Latitude = 24.04898,
                        Order = 434
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.798411,
                        Latitude = 24.049228,
                        Order = 435
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.798411,
                        Latitude = 24.049228,
                        Order = 436
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79756,
                        Latitude = 24.05087,
                        Order = 437
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79721,
                        Latitude = 24.051538,
                        Order = 438
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79721,
                        Latitude = 24.051538,
                        Order = 439
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.796347,
                        Latitude = 24.053184,
                        Order = 440
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79591,
                        Latitude = 24.05403,
                        Order = 441
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79552,
                        Latitude = 24.05484,
                        Order = 442
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79524,
                        Latitude = 24.05534,
                        Order = 443
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79465,
                        Latitude = 24.05633,
                        Order = 444
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79456,
                        Latitude = 24.056488,
                        Order = 445
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794248,
                        Latitude = 24.056953,
                        Order = 446
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.793937,
                        Latitude = 24.057353,
                        Order = 447
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79376,
                        Latitude = 24.05751,
                        Order = 448
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79353,
                        Latitude = 24.05771,
                        Order = 449
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79313,
                        Latitude = 24.05797,
                        Order = 450
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79294,
                        Latitude = 24.05806,
                        Order = 451
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.792553,
                        Latitude = 24.058199,
                        Order = 452
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79244,
                        Latitude = 24.05833,
                        Order = 453
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79242,
                        Latitude = 24.05836,
                        Order = 454
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79239,
                        Latitude = 24.05841,
                        Order = 455
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79238,
                        Latitude = 24.05845,
                        Order = 456
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79237,
                        Latitude = 24.05849,
                        Order = 457
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79236,
                        Latitude = 24.05854,
                        Order = 458
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79236,
                        Latitude = 24.0586,
                        Order = 459
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79237,
                        Latitude = 24.05865,
                        Order = 460
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79238,
                        Latitude = 24.05871,
                        Order = 461
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79239,
                        Latitude = 24.05875,
                        Order = 462
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.7924,
                        Latitude = 24.05879,
                        Order = 463
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79241,
                        Latitude = 24.05882,
                        Order = 464
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79245,
                        Latitude = 24.05889,
                        Order = 465
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.792528,
                        Latitude = 24.058985,
                        Order = 466
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79263,
                        Latitude = 24.05897,
                        Order = 467
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79268,
                        Latitude = 24.05896,
                        Order = 468
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79274,
                        Latitude = 24.05895,
                        Order = 469
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79295,
                        Latitude = 24.05888,
                        Order = 470
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.7931,
                        Latitude = 24.05881,
                        Order = 471
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79343,
                        Latitude = 24.05865,
                        Order = 472
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.793531,
                        Latitude = 24.05856,
                        Order = 473
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79363,
                        Latitude = 24.05852,
                        Order = 474
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79366,
                        Latitude = 24.05851,
                        Order = 475
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79371,
                        Latitude = 24.05853,
                        Order = 476
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79375,
                        Latitude = 24.05856,
                        Order = 477
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79379,
                        Latitude = 24.05859,
                        Order = 478
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79381,
                        Latitude = 24.058624,
                        Order = 479
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.793846,
                        Latitude = 24.05866,
                        Order = 480
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79386,
                        Latitude = 24.05874,
                        Order = 481
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79388,
                        Latitude = 24.05996,
                        Order = 482
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79388,
                        Latitude = 24.06007,
                        Order = 483
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79389,
                        Latitude = 24.06048,
                        Order = 484
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.7939,
                        Latitude = 24.06058,
                        Order = 485
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79391,
                        Latitude = 24.06067,
                        Order = 486
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79392,
                        Latitude = 24.06076,
                        Order = 487
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79398,
                        Latitude = 24.06118,
                        Order = 488
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794077,
                        Latitude = 24.061678,
                        Order = 489
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794326,
                        Latitude = 24.062953,
                        Order = 490
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79441,
                        Latitude = 24.063383,
                        Order = 491
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794447,
                        Latitude = 24.063572,
                        Order = 492
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794475,
                        Latitude = 24.063699,
                        Order = 493
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794498,
                        Latitude = 24.063801,
                        Order = 494
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794574,
                        Latitude = 24.064171,
                        Order = 495
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794685,
                        Latitude = 24.064758,
                        Order = 496
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794738,
                        Latitude = 24.065047,
                        Order = 497
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794738,
                        Latitude = 24.065047,
                        Order = 498
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794905,
                        Latitude = 24.065974,
                        Order = 499
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.795082,
                        Latitude = 24.066885,
                        Order = 500
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794984,
                        Latitude = 24.067087,
                        Order = 501
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794938,
                        Latitude = 24.067449,
                        Order = 502
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.79505,
                        Latitude = 24.067419,
                        Order = 503
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.795165,
                        Latitude = 24.06738,
                        Order = 504
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.795082,
                        Latitude = 24.066885,
                        Order = 505
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794905,
                        Latitude = 24.065974,
                        Order = 506
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794738,
                        Latitude = 24.065047,
                        Order = 507
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794685,
                        Latitude = 24.064758,
                        Order = 508
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794574,
                        Latitude = 24.064171,
                        Order = 509
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794498,
                        Latitude = 24.063801,
                        Order = 510
                    },
                    new RoutePoint
                    {
                        RouteId = route16.Id,
                        Direction = PointDirections.Backward,
                        Longitude = 49.794475,
                        Latitude = 24.063699,
                        Order = 511
                    }
                };
                #endregion

                context.RoutePoints.AddRange(forwardPoints);
                context.RoutePoints.AddRange(backwardPoints);
                context.RoutePoints.AddRange(forward3Points);
                context.RoutePoints.AddRange(backward3Points);
                context.RoutePoints.AddRange(forward16Points);
                context.RoutePoints.AddRange(backward16Points);
                context.SaveChanges();
            }
        }
    }
}