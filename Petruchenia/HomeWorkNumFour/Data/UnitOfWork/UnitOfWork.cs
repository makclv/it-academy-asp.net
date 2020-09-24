using Data.Context;
using Domain.UnitOfWork;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ICoreDbContext db;

        public UnitOfWork(ICoreDbContext db)
        {
            this.db = db;
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
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
