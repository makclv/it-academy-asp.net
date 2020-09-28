using Domain.UnitOfWork;
using Domain.Repository;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.Migrations;

namespace Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private IUnitOfWork unitOfWork;

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public virtual int Count()
        {
            return DbSet().Count();
        }

        public virtual void Create(T item)
        {
            DbSet().Add(item);
        }

        public void Delete(T item)
        {
            DbSet().Remove(item);
        }

        public T Get(object Id)
        {
            return DbSet().Find(Id);
        }

        public void Edit(T item)
        {
            DbSet().AddOrUpdate(item);
        }

        protected virtual IQueryable<T> GetAllFromDb()
        {
            return DbSet();
        }

        protected virtual IQueryable<T> GetItems()
        {
            return DbSet().AsQueryable();
        }

        private DbSet<T> DbSet()
        {
            return unitOfWork.Set<T>();
        }
    }
}
