using HW4.Data.Context.Interfaces;
using System.Data.Entity;

namespace HW4.Data.Context
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DatabaseContext()
                    : base("name=UsersDatabaseHW4")
        {
            Database.SetInitializer<DatabaseContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
        }
    }
}
