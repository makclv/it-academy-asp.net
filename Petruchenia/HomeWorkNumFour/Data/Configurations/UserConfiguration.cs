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

        Property(c => c.FirstName).IsRequired().HasColumnName("Firs Name");
        Property(c => c.LastName).IsRequired().HasColumnName("Last Name");

        Property(c => c.Email).IsRequired();

        Property(c => c.Phone).IsRequired();

        Property(c => c.Comment).IsOptional();

        HasRequired(c => c.City)
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
