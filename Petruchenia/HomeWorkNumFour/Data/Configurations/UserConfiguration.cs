using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration() 
        { 


            ToTable("Users");

        HasKey(s => s.UserId);

        Property(c => c.FName).IsRequired().HasColumnName("Firs Name").HasMaxLength(15);
        Property(c => c.LName).IsRequired().HasColumnName("Last Name").HasMaxLength(15);

        Property(c => c.Email).IsRequired().HasMaxLength(30);
        HasIndex(c => c.Email).IsUnique(true);

        Property(c => c.Phone).IsRequired().HasMaxLength(30);
        HasIndex(c => c.Phone).IsUnique(true);

        Property(c => c.Comment).IsOptional().HasMaxLength(500);

        HasRequired(c => c.Sity)
                .WithMany(c => c.Users)
                .Map(m => m.MapKey("CityId"))
                .WillCascadeOnDelete(false);

        HasRequired(c => c.Country)
                .WithMany(c => c.Users)
                .Map(m => m.MapKey("CountryId"))
                .WillCascadeOnDelete(false);

        Property(c => c.Title).IsRequired();


    }

}
}
