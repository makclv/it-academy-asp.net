using System.Data.Entity;

namespace OrderTrackingSystem.Data.Context
{
    public class TrackingSystemDbContext : DbContext, ITrackingSystemDbContext
    {
        public TrackingSystemDbContext()
            : base("name=TrackingSystemDb")
        {
            Database.SetInitializer<TrackingSystemDbContext>(null);
            
        }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
        }
    }
}
