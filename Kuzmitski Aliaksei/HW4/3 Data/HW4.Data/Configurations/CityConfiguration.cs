using HW4.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace HW4.Data.Configurations
{
    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            ToTable("Cities");

            HasKey(x => x.Id);

            Property(x => x.Name).IsRequired().HasMaxLength(25);

            HasRequired(x => x.Country)
                    .WithMany(x => x.Cities)
                    .Map(x => x.MapKey("CountryId"))
                    .WillCascadeOnDelete(false);
        }
    }
}
