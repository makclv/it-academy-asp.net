using OrderTrackingSystem.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace OrderTrackingSystem.Data.Configurations
{
    public class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        public CountryConfiguration()
        {
            ToTable("Countries");

            HasKey(c => c.Id);

            Property(c => c.Name).IsRequired().HasMaxLength(25);
            HasIndex(c => c.Name).IsUnique(true);

        }
    }
}
