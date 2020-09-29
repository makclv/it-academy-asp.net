namespace Data.Migrations
{
    using ClassLibrary1.Entities;
    using Domain.Entites;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.Context.CoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.Context.CoreDbContext context)
        {
            City California = new City() { CityName = "California" };
            City LA = new City() { CityName = "Los-Angeles" };
            City SF = new City() { CityName = "San Francisco" };

            City Poznan = new City() { CityName = "Poznan" };
            City Varshava = new City() { CityName = "Varshava" };
            City Vrotslav = new City() { CityName = "Vrotslav" };

            City Minsk = new City() { CityName = "Minsk" };
            City Gomel = new City() { CityName = "Gomel" };
            City Vitebsk = new City() { CityName = "Vitebsk" };

            Country USA = new Country()
            {
                CountryName = "USA",
                Cities = new List<City> { California, LA, SF }
            };

            Country Poland = new Country()
            {
                CountryName = "Poland",
                Cities = new List<City> { Poznan, Varshava, Vrotslav }
            };

            Country Belarus = new Country()
            {
                CountryName = "Belarus",
                Cities = new List<City> { Minsk, Gomel, Vitebsk }
            };

            User potter = new User()
            {
                FirstName = "Harry",
                LastName = "Potter",
                Phone = "1346578134",
                Email = "HarryP@magicschool.com",
                City = California,
                Country = USA,
                Title = Title.Mr,
                Comment = "Avana kedavra"
            };

            User germiona = new User()
            {
                FirstName = "Germiona",
                LastName = "Granger",
                Phone = "758373573",
                Email = "HermionaG@magicschool.com",
                City = LA,
                Country = USA,
                Title = Title.Mrs,
                Comment = "Avana kedavra"
            };

            context.Set<Country>().AddOrUpdate(Poland);
            context.Set<Country>().AddOrUpdate(Belarus);
            context.Set<Country>().AddOrUpdate(USA);
            context.Set<User>().AddOrUpdate(potter);
            context.Set<User>().AddOrUpdate(germiona);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
