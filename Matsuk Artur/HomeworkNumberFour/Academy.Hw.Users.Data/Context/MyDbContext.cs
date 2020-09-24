
using ItAcademy.Hw.Users.Data.Initializer;
using System.Data.Entity;

namespace ItAcademy.Hw.Users.Data.Context
{
   public class MyDbContext : DbContext, IMyDbContext
    {
       

        public MyDbContext()
            : base("name=testDb")
        {
            Database.SetInitializer(new ContextInitializer());

        }

        
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
        }
    }
    
}
