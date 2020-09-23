using OrderTrackingSystem.Data.Context;
using OrderTrackingSystem.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace InitializersDb
{
    public class SeedDb
    {
        public SeedDb()
        {

            Seed();
        }



        private void Seed()
        {
            using (TrackingSystemDbContext db = new TrackingSystemDbContext())
            {

                if (!db.Set<Country>().Any())
                {
                    List<Country> countries = new List<Country>()
                    {
                        new Country() {Name = "Беларусь"},
                        new Country() {Name = "Россия"},
                        new Country() {Name = "США"},
                        new Country() {Name = "Великобритания"},
                        new Country() {Name = "Франция"},
                        new Country() {Name = "Нидерланды"}

                    };
                    db.Set<Country>().AddRange(countries);
                    db.SaveChanges();
                }

                if (!db.Set<City>().Any())
                {
                    var countries = db.Set<Country>().ToList();

                    List<City> cities = new List<City>()
                    {
                        new City() {Name = "Минск",Country = countries.FirstOrDefault(c=>c.Name == "Беларусь" ) },
                        new City() {Name = "Брест",Country = countries.FirstOrDefault(c=>c.Name == "Беларусь" ) },
                        new City() {Name = "Москва",Country = countries.FirstOrDefault(c=>c.Name == "Россия" ) },
                        new City() {Name = "Гродно" ,Country = countries.FirstOrDefault(c=>c.Name == "Беларусь" )},
                        new City() {Name = "Нью-Йорк",Country = countries.FirstOrDefault(c=>c.Name == "США" ) },
                        new City() {Name = "Вншингтон" ,Country = countries.FirstOrDefault(c=>c.Name == "США" )},
                        new City() {Name = "Париж",Country = countries.FirstOrDefault(c=>c.Name == "Франция" ) },
                        new City() {Name = "Лондон",Country = countries.FirstOrDefault(c=>c.Name == "Великобритания" ) },
                        new City() {Name = "Гаага" ,Country = countries.FirstOrDefault(c=>c.Name == "Нидерланды" )},
                        new City() {Name = "Санкт-Петербург" ,Country = countries.FirstOrDefault(c=>c.Name == "Россия" )},
                        new City() {Name = "Марсель" ,Country = countries.FirstOrDefault(c=>c.Name == "Франция" )}

                    };
                    db.Set<City>().AddRange(cities);
                    db.SaveChanges();
                }
            }

        }
    }
}
