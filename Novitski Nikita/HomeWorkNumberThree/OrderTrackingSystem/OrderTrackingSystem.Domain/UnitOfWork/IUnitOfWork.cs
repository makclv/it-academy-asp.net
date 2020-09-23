using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace OrderTrackingSystem.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        DbSet<TEntity> Set<TEntity>()
            where TEntity : class;

        int SaveChanges();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity)
           where TEntity : class;
    }
}
