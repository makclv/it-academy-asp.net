using System.Data.Entity.Infrastructure;
using System.Data.Entity;

namespace ItAcademy.Hw.Users.Data.Context
{
    public interface IMyDbContext
    {
        DbSet<TEntity> Set<TEntity>()
            where TEntity : class;

        int SaveChanges();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity)
            where TEntity : class;
    }
}
