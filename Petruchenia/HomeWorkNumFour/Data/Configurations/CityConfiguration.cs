using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {

            ToTable("City");

            HasKey(s => s.CityId);

            Property(p => p.CityName);

            HasRequired(c => c.Country)
                .WithMany(c => c.Cities)
                .Map(c => c.MapKey("CountryId"))
                .WillCascadeOnDelete(false);

        }

    }
}
