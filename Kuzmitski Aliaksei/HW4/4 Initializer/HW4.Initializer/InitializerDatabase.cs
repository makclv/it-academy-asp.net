using HW4.Data.Context;
using HW4.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace HW4.Initializer
{
    public class InitializerDatabase : IInitializerDatabase
    {
        public void InitializeDatabase()
        {
            Seed();
        }

        private void Seed()
        {
            DatabaseContext databaseContext = new DatabaseContext();
            if (!databaseContext.Set<Country>().Any())
            {
                var countries = new List<Country>
                            {
                                new Country(){Name = "Belarus"},
                                new Country(){Name = "Russia"},
                                new Country(){Name = "Ukraine"},
                                new Country(){Name = "Poland"},
                                new Country(){Name = "Lituania"},
                                new Country(){Name = "Latvia"},
                                new Country(){Name = "USA"},
                                new Country(){Name = "Germany"},
                                new Country(){Name = "China"},
                                new Country(){Name = "France"},
                                new Country(){Name = "Great Britain"},
                            };
                databaseContext.Set<Country>().AddRange(countries);
                databaseContext.SaveChanges();
            }

            if (!databaseContext.Set<City>().Any())
            {
                var countries = databaseContext.Set<Country>().ToList();
                var cities = new List<City>
                            {
                                new City(){Name = "Minsk", Country = countries.FirstOrDefault(x => x.Name.Equals("Belarus"))},
                                new City(){Name = "Gomel", Country = countries.FirstOrDefault(x => x.Name.Equals("Belarus"))},
                                new City(){Name = "Vitebsk", Country = countries.FirstOrDefault(x => x.Name.Equals("Belarus"))},
                                new City(){Name = "Mogilev", Country = countries.FirstOrDefault(x => x.Name.Equals("Belarus"))},
                                new City(){Name = "Grodno", Country = countries.FirstOrDefault(x => x.Name.Equals("Belarus"))},
                                new City(){Name = "Brest", Country = countries.FirstOrDefault(x => x.Name.Equals("Belarus"))},
                                new City(){Name = "Moscow", Country = countries.FirstOrDefault(x => x.Name.Equals("Russia"))},
                                new City(){Name = "Saint Petersburg", Country = countries.FirstOrDefault(x => x.Name.Equals("Russia"))},
                                new City(){Name = "Novosibirsk", Country = countries.FirstOrDefault(x => x.Name.Equals("Russia"))},
                                new City(){Name = "Kiev", Country = countries.FirstOrDefault(x => x.Name.Equals("Ukraine"))},
                                new City(){Name = "Kharkiv", Country = countries.FirstOrDefault(x => x.Name.Equals("Ukraine"))},
                                new City(){Name = "Odessa", Country = countries.FirstOrDefault(x => x.Name.Equals("Ukraine"))},
                                new City(){Name = "Warsaw", Country = countries.FirstOrDefault(x => x.Name.Equals("Poland"))},
                                new City(){Name = "Krakow", Country = countries.FirstOrDefault(x => x.Name.Equals("Poland"))},
                                new City(){Name = "Lodz", Country = countries.FirstOrDefault(x => x.Name.Equals("Poland"))},
                                new City(){Name = "Vilnius", Country = countries.FirstOrDefault(x => x.Name.Equals("Lituania"))},
                                new City(){Name = "Riga", Country = countries.FirstOrDefault(x => x.Name.Equals("Latvia"))},
                                new City(){Name = "NY", Country = countries.FirstOrDefault(x => x.Name.Equals("USA"))},
                                new City(){Name = "Los Angeles", Country = countries.FirstOrDefault(x => x.Name.Equals("USA"))},
                                new City(){Name = "Chicago", Country = countries.FirstOrDefault(x => x.Name.Equals("USA"))},
                                new City(){Name = "Berlin", Country = countries.FirstOrDefault(x => x.Name.Equals("Germany"))},
                                new City(){Name = "Hamburg", Country = countries.FirstOrDefault(x => x.Name.Equals("Germany"))},
                                new City(){Name = "Munich", Country = countries.FirstOrDefault(x => x.Name.Equals("Germany"))},
                                new City(){Name = "Chongqing", Country = countries.FirstOrDefault(x => x.Name.Equals("China"))},
                                new City(){Name = "Shanghai", Country = countries.FirstOrDefault(x => x.Name.Equals("China"))},
                                new City(){Name = "Beijing", Country = countries.FirstOrDefault(x => x.Name.Equals("China"))},
                                new City(){Name = "Paris", Country = countries.FirstOrDefault(x => x.Name.Equals("France"))},
                                new City(){Name = "Marseilles", Country = countries.FirstOrDefault(x => x.Name.Equals("France"))},
                                new City(){Name = "Lyons", Country = countries.FirstOrDefault(x => x.Name.Equals("France"))},
                                new City(){Name = "London", Country = countries.FirstOrDefault(x => x.Name.Equals("Great Britain"))},
                                new City(){Name = "Birmingham", Country = countries.FirstOrDefault(x => x.Name.Equals("Great Britain"))},
                                new City(){Name = "Leeds", Country = countries.FirstOrDefault(x => x.Name.Equals("Great Britain"))},
                            };
                databaseContext.Set<City>().AddRange(cities);
                databaseContext.SaveChanges();
            }
        }
    }
}