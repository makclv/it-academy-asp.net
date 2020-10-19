using System.Data.Entity.Migrations;

namespace ItAcademy.Demo.ClassWork.Infrastructure.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Context.CoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context.CoreDbContext context)
        {
        }
    }
}
