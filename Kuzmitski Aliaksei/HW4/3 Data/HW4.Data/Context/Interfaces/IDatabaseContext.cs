using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace HW4.Data.Context.Interfaces
{
    public interface IDatabaseContext
    {
        DbSet<TEntity> Set<TEntity>()
                    where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity)
            where TEntity : class;

        int SaveChanges();
    }
}
