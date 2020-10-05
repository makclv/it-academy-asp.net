using OrderTrackingSystem.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace OrderTrackingSystem.Data.Configurations
{
    class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            ToTable("Cities");

            HasKey(c => c.Id);

            Property(c => c.Name).IsRequired().HasMaxLength(20);

            HasRequired(c => c.Country)
                .WithMany(c => c.Cities)
                .Map(c => c.MapKey("CountryId"))
                .WillCascadeOnDelete(false);

        }
    }
}
