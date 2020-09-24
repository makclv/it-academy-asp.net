
using ItAcademy.Hw.Users.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItAcademy.Hw.Users.Data.Configurations
{
    class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            ToTable("Users");

            HasKey(s => s.Id);

            Property(c => c.Name).IsRequired().HasMaxLength(20);

            Property(c => c.Surname).IsRequired().HasMaxLength(20);

            Property(c => c.Email).IsRequired().HasMaxLength(30);
            HasIndex(c => c.Email).IsUnique(true);

            Property(c => c.Phone).IsRequired().HasMaxLength(30);
            HasIndex(c => c.Phone).IsUnique(true);

            Property(c => c.Comments).HasMaxLength(500);

            Property(c => c.Title).IsRequired();

            HasRequired(c => c.City)
                .WithMany(c => c.Users)
                .Map(m => m.MapKey("CityId"))
                .WillCascadeOnDelete(false);

            HasRequired(c => c.Country)
                .WithMany(c => c.Users)
                .Map(m => m.MapKey("CountryId"))
                .WillCascadeOnDelete(false);

            
        }
    }
}
