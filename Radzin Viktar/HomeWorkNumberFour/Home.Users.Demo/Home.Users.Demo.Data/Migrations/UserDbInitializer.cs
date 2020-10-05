using Home.Users.Demo.Data.Context;
using Home.Users.Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Users.Demo.Data.Migrations
{
    class UserDbInitializer : DropCreateDatabaseAlways<UserDbContext>
    {
        protected override void Seed(UserDbContext context)
        {
            Country country1 = new Country { Name = "Belarus" };
            Country country2 = new Country { Name = "Russia" };
            Country country3 = new Country { Name = "England" }; 
            context.Countries.Add(country1);
            context.Countries.Add(country2);
            context.Countries.Add(country3);
            City city1 = new City { Name = "Minsk" , Country =country1 };
            City city2 = new City { Name = "Moscow", Country = country2 };
            City city3 = new City { Name = "London", Country = country3};
            context.Cities.Add(city1);
            context.Cities.Add(city2);
            context.Cities.Add(city3);
            context.SaveChanges();
            User User1 = new User { FirstName = "Viktar", LastName = "Radzin", Phone = "375296152517", Email = "viktarradzin@outlook.com", Title = Title.Dr, Country = country1 , City  = city1};
            User User2 = new User { FirstName = "Vasiliy", LastName = "Petrovich", Phone = "375336223322", Email = "vas@tut.by", Title = Title.Mr, Country = country2, City = city2 };
            User User3 = new User { FirstName = "Angelina", LastName = "Fsesssa", Phone = "3753363333322", Email = "angelina@tut.by", Title = Title.Mr , Country=country3, City = city3};
            context.Users.Add(User1);
            context.Users.Add(User2);
            context.Users.Add(User3);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
