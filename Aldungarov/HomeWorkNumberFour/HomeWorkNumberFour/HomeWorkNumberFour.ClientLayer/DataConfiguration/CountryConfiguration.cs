using HomeWorkNumberFour.BLL.Models;
using System.Data.Entity.ModelConfiguration;

namespace HomeWorkNumberFour.ClientLayer.DataConfiguration
{
    public class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        public CountryConfiguration()
        {
            ToTable("Country");

            HasKey(s => s.Id);

            Property(p => p.CountryName);
        }
    }
}
