using HomeWorkNumberFour.BLL.Models;
using System.Data.Entity;

namespace HomeWorkNumberFour.ClientLayer.Context
{
    public class DBContext : DbContext, IDBContext
    {
        //public DBContext() : base("name=DBConnection")
        //public DBContext() : base("DBConnectionTest")
        //public DBContext() : base("DBConnectionTest2")
        public DBContext() : base(@"Server=localhost\MSSQLSERVER01;Database=master;Trusted_Connection=True")
        {
            Database.SetInitializer(new NullDatabaseInitializer<DBContext>());
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
        }
    }

    //public class SampleInitializer
    //    : CreateDatabaseIfNotExists<DBContext>
    //{
    //    // В этом методе можно заполнить таблицу по умолчанию
    //    protected override void Seed(DBContext context)
    //    {
    //        List<City> cities = new List<City>
    //        {
    //            new City { CityName = "Gavana" },
    //            new City { CityName = "London" },
    //            new City { CityName = "Hells Bells" }
    //        };

    //        foreach (City city in cities)
    //            context.Cities.Add(city);

    //        List<Country> countries = new List<Country>
    //        {
    //            new Country { CountryName = "USA" },
    //            new Country { CountryName = "Russia" },
    //            new Country { CountryName = "England" },
    //            new Country { CountryName = "Hells Bells C" }
    //        };

    //        foreach (Country country in countries)
    //            context.Countries.Add(country);

    //        List<User> users = new List<User>
    //        {
    //            new User
    //            {
    //                Id = 1,
    //                FirstName = "Джерри",
    //                LastName = "Брукхаймер",
    //                Title = Title.Dr,
    //                Phone = "+375-11-111-11-11",
    //                Email = "Testing1@gmail.com",
    //                Address = new Address() { CountryName = "USA", CityName = "Hasselhoff" },
    //                Comments = "Some comment 1."
    //            },
    //            new User
    //            {
    //                Id = 2,
    //                FirstName = "Джордж",
    //                LastName = "Лукас",
    //                Title = Title.Mr,
    //                Phone = "+375-22-222-22-22",
    //                Email = "Testing2@gmail.com",
    //                Address = new Address() { CountryName = "USA", CityName = "Hasselhoff" },
    //                Comments = "Some comment 2."
    //            },
    //            new User
    //            {
    //                Id = 3,
    //                FirstName = "Майкл",
    //                LastName = "Бэй",
    //                Title = Title.Dr,
    //                Phone = "+375-33-333-33-33",
    //                Email = "Testing3@gmail.com",
    //                Address = new Address() { CountryName = "USA", CityName = "Danch Wood" },
    //                Comments = "Some comment 3."
    //            },
    //            new User
    //            {
    //                Id = 4,
    //                FirstName = "Тайлер",
    //                LastName = "Перри",
    //                Title = Title.Mr,
    //                Phone = "+375-44-444-44-44",
    //                Email = "Testing_4@gmail.com",
    //                Address = new Address() { CountryName = "Russia", CityName = "Moscow" },
    //                Comments = "Some comment 4."
    //            },
    //            new User
    //            {
    //                Id = 5,
    //                FirstName = "Стивен",
    //                LastName = "Спилберг",
    //                Title = Title.Dr,
    //                Phone = "+375-55-555-55-55",
    //                Email = "Testing1@gmail.com",
    //                Address = new Address() { CountryName = "Russia", CityName = "Moscow" },
    //                Comments = "Some comment."
    //            }
    //        };

    //        foreach (User user in users)
    //            context.Users.Add(user);


    //        context.SaveChanges();
    //        base.Seed(context);
    //    }
    //}
}
