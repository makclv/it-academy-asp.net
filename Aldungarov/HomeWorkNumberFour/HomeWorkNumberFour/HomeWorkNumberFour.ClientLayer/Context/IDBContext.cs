using System.Data.Entity;

namespace HomeWorkNumberFour.ClientLayer.Context
{
    public interface IDBContext
    {
        DbSet<TEntity> Set<TEntity>()
            where TEntity : class;

        int SaveChanges();
    }
}
