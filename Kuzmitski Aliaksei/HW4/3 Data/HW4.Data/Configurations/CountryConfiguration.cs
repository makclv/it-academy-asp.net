using HW4.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace HW4.Data.Configurations
{
    public class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        public CountryConfiguration()
        {
            ToTable("Countries");

            HasKey(x => x.Id);

            Property(x => x.Name).IsRequired().HasMaxLength(30);
            HasIndex(x => x.Name).IsUnique(true);
        }
    }
}
