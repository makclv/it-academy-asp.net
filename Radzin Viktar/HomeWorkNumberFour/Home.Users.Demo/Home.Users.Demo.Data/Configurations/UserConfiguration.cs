using Home.Users.Demo.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Home.Users.Demo.Data.Configurations
{
    class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users");
            HasKey<int>(x => x.UserId);
            Property(x => x.FirstName).HasMaxLength(20).IsRequired();
            Property(x => x.LastName).HasMaxLength(20).IsRequired();
            Property(x => x.Phone).HasMaxLength(15).IsRequired();
            Property(x => x.Email).HasMaxLength(25).IsRequired();
            Property(x => x.Title).HasColumnType("int").IsRequired();
            HasRequired(x => x.Country)
                .WithMany(x => x.Users)
                .WillCascadeOnDelete(false);
            HasRequired(x => x.City)
                .WithMany(x => x.Users)
                .WillCascadeOnDelete(false);
        }
    }
}
