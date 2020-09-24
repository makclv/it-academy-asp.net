
using ItAcademy.Hw.Users.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItAcademy.Hw.Users.Data.Configurations
{
    class CountryConfig : EntityTypeConfiguration<Country>
    {
        public CountryConfig()
        {
            ToTable("Countries");

            HasKey(c => c.Id);

            Property(c => c.Name).IsRequired().HasMaxLength(20);
            HasIndex(c => c.Name).IsUnique(true);
        }
    }
}
