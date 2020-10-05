using HW4.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace HW4.Data.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users");

            HasKey(x => x.Id);

            Property(x => x.FirstName).IsRequired().HasColumnName("First Name").HasMaxLength(20);

            Property(x => x.LastName).IsRequired().HasColumnName("Last Name").HasMaxLength(30);

            Property(c => c.Title).IsRequired();

            Property(x => x.Phone).IsRequired().HasMaxLength(15);
            HasIndex(x => x.Phone).IsUnique(true);

            Property(x => x.Email).IsRequired().HasMaxLength(30);
            HasIndex(x => x.Email).IsUnique(true);

            Property(x => x.Comments).IsOptional().HasMaxLength(300);

            HasRequired(x => x.Country)
                    .WithMany(x => x.Users)
                    .Map(x => x.MapKey("CountryId"))
                    .WillCascadeOnDelete(false);

            HasRequired(x => x.City)
                    .WithMany(x => x.Users)
                    .Map(x => x.MapKey("CityId"))
                    .WillCascadeOnDelete(false);
        }
    }
}
