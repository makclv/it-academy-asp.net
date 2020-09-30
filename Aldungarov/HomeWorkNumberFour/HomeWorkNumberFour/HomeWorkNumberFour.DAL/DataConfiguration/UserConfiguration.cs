using HomeWorkNumberFour.BLL.Models;
using System.Data.Entity.ModelConfiguration;

namespace HomeWorkNumberFour.ClientLayer.DataConfiguration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users");

            HasKey(s => s.Id);

            Property(p => p.FirstName);
            Property(p => p.LastName);
            Property(p => p.Phone);
            Property(p => p.Email);
            Property(p => p.Title);
            Property(p => p.Comments);
        }
    }
}