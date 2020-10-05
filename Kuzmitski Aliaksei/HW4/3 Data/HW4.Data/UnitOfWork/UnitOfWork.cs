using HW4.Data.Context.Interfaces;
using HW4.Domain.UnitOfWork.Interfaces;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace HW4.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseContext database;

        public UnitOfWork(IDatabaseContext database)
        {
            this.database = database;
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return database.Set<TEntity>();
        }

        public DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            return database.Entry<TEntity>(entity);
        }

        public int SaveChanges()
        {
            return database.SaveChanges();
        }
    }
}
