using System.Data.Entity;

namespace Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        DbSet<TEntity> Set<TEntity>()
            where TEntity : class;

        int SaveChanges();
    }
}
