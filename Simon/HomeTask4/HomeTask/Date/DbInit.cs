using HomeTask.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HomeTask.Date
{
    public class DBInitializer : DropCreateDatabaseAlways<DbContextUserRepository>
    {
        protected override void Seed(DbContextUserRepository context)
        { 
            IList<Country> defaultCountry = new List<Country>();
            IList<City> defaultCity = new List<City>();

            var country = new Country() { CountryName = "Germany", Cities = new List<City>()};
            var city = new City() { СityName = "Gomel", Country = country};
            country.Cities.Add(city);
            var country1 = new Country() { CountryName = "Poland", Cities = new List<City>()};
            var city1 = new City() { СityName = "Minsk", Country = country1};
            country1.Cities.Add(city1);

            defaultCity.Add(city);
            defaultCountry.Add(country);
            defaultCity.Add(city1);
            defaultCountry.Add(country1);
            context.Countrys.AddRange(defaultCountry);
            context.Cities.AddRange(defaultCity);

            base.Seed(context);
        }
    }
}