using HomeWorkNumberFour.BLL.Models;
using System.Data.Entity.ModelConfiguration;

namespace HomeWorkNumberFour.ClientLayer.DataConfiguration
{
    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            this.HasKey(s => s.Id);
            this.Property(c => c.CityName).IsRequired().HasMaxLength(30);
            this.ToTable("Cities");
        }
    }
}
