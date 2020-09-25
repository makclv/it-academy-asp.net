using Home.Users.Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Users.Demo.Data.Configurations
{
    class CityCinfiguration : EntityTypeConfiguration<City>
    {
        public CityCinfiguration () 
        {
            ToTable("Cities");
        }
    }
}
