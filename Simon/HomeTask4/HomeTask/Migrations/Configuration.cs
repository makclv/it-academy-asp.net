namespace HomeTask.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HomeTask.Date.DbContextUserRepository>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "HomeTask.Date.DbContextUserRepository";
        }

        protected override void Seed(HomeTask.Date.DbContextUserRepository context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
