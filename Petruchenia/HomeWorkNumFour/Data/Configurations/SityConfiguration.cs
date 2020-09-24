using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class SityConfiguration : EntityTypeConfiguration<Sity>
    {
        public SityConfiguration()
        {

            ToTable("Sity");

            HasKey(s => s.SityId);

            Property(p => p.SityName).IsRequired().HasMaxLength(25);

            HasRequired(c => c.Country)
                .WithMany(c => c.Sities)
                .Map(c => c.MapKey("CountryId"))
                .WillCascadeOnDelete(false);

        }

    }
}
