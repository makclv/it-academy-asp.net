using System.Data.Entity;

namespace HomeWorkNumberFour.BLL.UnitOfWork
{
    public interface IUnitOfWork
    {
        DbSet<TEntity> Set<TEntity>()
            where TEntity : class;

        int SaveChanges();
    }
}
