using System.Data.Entity;

namespace Data.Context
{
    public class CoreDbContext : DbContext, ICoreDbContext
    {
        public CoreDbContext() : base("data source=.;initial catalog=HomeWork;integrated security=True;MultipleActiveResultSets=true;")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
        }

    }
}