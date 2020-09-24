using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }

    }
}