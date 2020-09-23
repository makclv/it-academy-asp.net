using Home.Users.Demo.Data.Migrations;
using Home.Users.Demo.Domain.Entities;
using System.Data.Entity;

namespace Home.Users.Demo.Data.Context
{
    public class UserDbContext : DbContext, IUserDbContext
    {
        public UserDbContext()
          : base("HomeUsersDemo")
        {
            Database.SetInitializer(new UserDbInitializer());
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
}
