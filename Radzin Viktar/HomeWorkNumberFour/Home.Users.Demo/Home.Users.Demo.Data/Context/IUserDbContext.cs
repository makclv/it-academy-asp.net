using System.Data.Entity;

namespace Home.Users.Demo.Data.Context
{
    public interface IUserDbContext
    {
        DbSet<TEntity> Set<TEntity>()
            where TEntity : class;

        int SaveChanges();
    }
}
