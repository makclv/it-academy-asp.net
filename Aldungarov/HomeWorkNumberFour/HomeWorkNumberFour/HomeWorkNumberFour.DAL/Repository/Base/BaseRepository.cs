using HomeWorkNumberFour.BLL.Interfaces.Repository.Base;
using HomeWorkNumberFour.BLL.UnitOfWork;
using System.Data.Entity;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace HomeWorkNumberFour.ClientLayer.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private IUnitOfWork _unitOfWork;

        protected BaseRepository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public virtual void Create(TEntity entity)
        {
            DBSet().AddOrUpdate(entity);
            
            //_unitOfWork.SaveChanges();
        }

        public virtual void AddOrUpdate(TEntity entity)
        {
            DBSet().AddOrUpdate(entity);

            _unitOfWork.SaveChanges();
        }

        public virtual void Delete(TEntity entity)
        {
            DBSet().Remove(entity);
            
            _unitOfWork.SaveChanges();
        }

        public virtual List<TEntity> GetAll()
        {
            return DBSet().ToList();
        }

        private DbSet<TEntity> DBSet()
        {
            return _unitOfWork.Set<TEntity>();
        }
    }
}
