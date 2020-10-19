using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ItAcademy.Demo.ClassWork.Infrastructure.Data.Context
{
    public class CoreDbContext : IdentityDbContext, ICoreDbContext
    {
        public CoreDbContext()
            : base("name=ItAcademyCoreDb")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
        }
    }
}
