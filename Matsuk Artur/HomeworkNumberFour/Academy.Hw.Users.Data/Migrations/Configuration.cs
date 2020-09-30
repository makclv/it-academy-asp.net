namespace ItAcademy.Hw.Users.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ItAcademy.Hw.Users.Data.Context;
    using ItAcademy.Hw.Users.Domain.Models;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    internal sealed class Configuration : DbMigrationsConfiguration<ItAcademy.Hw.Users.Data.Context.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ItAcademy.Hw.Users.Data.Context.MyDbContext db)
        {
            


                List<Country> countries = new List<Country>()
                    {
                         new Country() {Name = "США"},
                        new Country() {Name = "Беларусь"},
                        new Country() {Name = "Россия"},
                        new Country() {Name = "Германия"},
                        new Country() {Name = "Великобритания"}

                        

                    };
            
                db.Set<Country>().AddRange(countries);
                db.SaveChanges();


                if (!db.Set<City>().Any())
                {
                    var temp = db.Set<Country>().ToList();

                    List<City> cities = new List<City>()
                    {
                        new City() {Name = "Минск",Country = temp.FirstOrDefault(c=>c.Name == "Беларусь" ) },
                         new City() {Name = "Гродно",Country = temp.FirstOrDefault(c=>c.Name == "Беларусь" ) },
                          new City() {Name = "Витебск",Country = temp.FirstOrDefault(c=>c.Name == "Беларусь" ) },
                           new City() {Name = "Могилев",Country = temp.FirstOrDefault(c=>c.Name == "Беларусь" ) },
                        new City() {Name = "Москва",Country = temp.FirstOrDefault(c=>c.Name == "Россия" ) },
                         new City() {Name = "Санкт-Петербург",Country = temp.FirstOrDefault(c=>c.Name == "Россия" ) },
                          new City() {Name = "Сызрань",Country = temp.FirstOrDefault(c=>c.Name == "Россия" ) },
                           new City() {Name = "Владивосток",Country = temp.FirstOrDefault(c=>c.Name == "Россия" ) },
                            new City() {Name = "Екатеринбург",Country = temp.FirstOrDefault(c=>c.Name == "Россия" ) },
                        new City() {Name = "Нью-Йорк",Country = temp.FirstOrDefault(c=>c.Name == "США" ) },
                         new City() {Name = "Лос-Анджелес",Country = temp.FirstOrDefault(c=>c.Name == "США" ) },
                          new City() {Name = "Чикаго",Country = temp.FirstOrDefault(c=>c.Name == "США" ) },
                           new City() {Name = "Хьюстон",Country = temp.FirstOrDefault(c=>c.Name == "США" ) },
                        new City() {Name = "Лондон",Country = temp.FirstOrDefault(c=>c.Name == "Великобритания" ) },
                         new City() {Name = "Глазго",Country = temp.FirstOrDefault(c=>c.Name == "Великобритания" ) },
                          new City() {Name = "Шеффилд",Country = temp.FirstOrDefault(c=>c.Name == "Великобритания" ) },
                           new City() {Name = "Манчестер",Country = temp.FirstOrDefault(c=>c.Name == "Великобритания" ) },
                           new City() {Name = "Оксфорд",Country = temp.FirstOrDefault(c=>c.Name == "Великобритания" ) },
                        new City() {Name = "Берлин" ,Country = temp.FirstOrDefault(c=>c.Name == "Германия" )},
                        new City() {Name = "Гамбург" ,Country = temp.FirstOrDefault(c=>c.Name == "Германия" )},
                        new City() {Name = "Мюнхен" ,Country = temp.FirstOrDefault(c=>c.Name == "Германия" )},
                        new City() {Name = "Кёльн" ,Country = temp.FirstOrDefault(c=>c.Name == "Германия" )},
                        new City() {Name = "Штутгарт" ,Country = temp.FirstOrDefault(c=>c.Name == "Германия" )},
                        new City() {Name = "Дюссельдорф" ,Country = temp.FirstOrDefault(c=>c.Name == "Германия" )}

                    };
                    db.Set<City>().AddRange(cities);
                    db.SaveChanges();
                }
            
        }
    }
}
