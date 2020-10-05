using Home.Users.Demo.Data.Context;
using Home.Users.Demo.Domain.UnitOfWork;
using System.Data.Entity;

namespace Home.Users.Demo.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IUserDbContext db;
        

        public UnitOfWork(IUserDbContext db)
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
