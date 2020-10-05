using HW4.Domain.Repositories.Interfaces;
using HW4.Domain.UnitOfWork.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HW4.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly IUnitOfWork unitOfWork;

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        private DbSet<T> DbSet()
        {
            return unitOfWork.Set<T>();
        }

        public virtual void Add(T item)
        {
            DbSet().Add(item);
        }

        public virtual void Delete(T item)
        {
            DbSet().Remove(item);
        }

        public virtual void DeleteById(int itemId)
        {
            Delete(Get(itemId));
        }

        public virtual T Get(int id)
        {
            return DbSet().Find(id);
        }

        public virtual List<T> GetAll()
        {
            return DbSet().ToList();
        }

        protected virtual IQueryable<T> GetSelectedInfo()
        {
            return DbSet().AsQueryable();
        }
    }
}