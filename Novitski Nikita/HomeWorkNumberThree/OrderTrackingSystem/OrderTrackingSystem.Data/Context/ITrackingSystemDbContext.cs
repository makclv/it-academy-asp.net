using System.Data.Entity.Infrastructure;
using System.Data.Entity;


namespace OrderTrackingSystem.Data.Context
{
    public interface ITrackingSystemDbContext
    {
        DbSet<TEntity> Set<TEntity>()
            where TEntity : class;

        int SaveChanges();
      
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity)
            where TEntity : class;

    }
}
