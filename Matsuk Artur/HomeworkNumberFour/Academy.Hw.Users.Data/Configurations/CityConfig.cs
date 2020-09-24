
using ItAcademy.Hw.Users.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace ItAcademy.Hw.Users.Data.Configurations
{
    class CityConfig : EntityTypeConfiguration<City>
    {
        public CityConfig()
        {
            ToTable("Cities");

            HasKey(c => c.Id);

            Property(c => c.Name).IsRequired().HasMaxLength(30);

            HasRequired(c => c.Country)
                .WithMany(c => c.Cities)
                .Map(c => c.MapKey("CountryId"))
                .WillCascadeOnDelete(false);
        }
    }
}
