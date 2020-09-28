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
            AutomaticMigrationsEnabled = true;
            ContextKey = "Data.Context.CoreDbContext";
        }

        protected override void Seed(Data.Context.CoreDbContext context)
        {
            Sity California = new Sity() { SityName = "California"};
            Sity LA = new Sity() { SityName = "Los-Angeles" };
            Sity SF = new Sity() { SityName = "San Francisco" };

            Sity Poznan = new Sity() { SityName = "Poznan" };
            Sity Varshava = new Sity() { SityName = "Varshava" };
            Sity Vrotslav = new Sity() { SityName = "Vrotslav" };

            Sity Minsk = new Sity() { SityName = "Minsk" };
            Sity Gomel = new Sity() { SityName = "Gomel" };
            Sity Vitebsk = new Sity() { SityName = "Vitebsk" };

            Country USA = new Country() 
            {
                CountryName = "USA",
                Sities = new List<Sity> { California, LA, SF }
            };

            Country Poland = new Country()
            {
                CountryName = "Poland",
                Sities = new List<Sity> { Poznan, Varshava, Vrotslav }
            };

            Country Belarus = new Country()
            {
                CountryName = "Belarus",
                Sities = new List<Sity> { Minsk, Gomel, Vitebsk }
            };

            User potter = new User()
            {
                FName = "Harry",
                LName = "Potter",
                Phone = "1346578134",
                Email = "HarryP@magicschool.com",
                Sity = California,
                Country = USA,
                Title = Title.Mr,
                Comment = "Avana kedavra"
            };

            User germiona = new User()
            {
                FName = "Germiona",
                LName = "Granger",
                Phone = "758373573",
                Email = "HermionaG@magicschool.com",
                Sity = LA,
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
