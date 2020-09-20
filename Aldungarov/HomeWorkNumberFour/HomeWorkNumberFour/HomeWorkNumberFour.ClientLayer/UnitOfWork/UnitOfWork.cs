using HomeWorkNumberFour.BLL.UnitOfWork;
using HomeWorkNumberFour.ClientLayer.Context;
using System.Data.Entity;

namespace HomeWorkNumberFour.ClientLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDBContext db;

        public UnitOfWork(IDBContext db)
        {
            this.db = db;
        }

        public DbSet<TEntity> Set<TEntity>()
            where TEntity : class
        {
            return db.Set<TEntity>();
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }
    }
}
