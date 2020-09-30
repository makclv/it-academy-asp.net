using HomeWorkNumberFour.BLL.Models;
using System.Data.Entity.ModelConfiguration;

namespace HomeWorkNumberFour.ClientLayer.DataConfiguration
{
    public class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        public CountryConfiguration()
        {
            this.HasKey(s => s.Id);
            this.Property(c => c.CountryName).IsRequired().HasMaxLength(30);
            this.ToTable("Country");
        }
    }
}
