using OrderTrackingSystem.Data.Context;
using OrderTrackingSystem.Domain.UnitOfWork;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace OrderTrackingSystem.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ITrackingSystemDbContext db;

        public UnitOfWork(ITrackingSystemDbContext db)
        {
            this.db = db;
        }      

        public DbSet<TEntity> Set<TEntity>()
            where TEntity : class
        {
            return db.Set<TEntity>();
        }

        public DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity)
            where TEntity : class
        {
           return db.Entry<TEntity>(entity);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }
    }
}
