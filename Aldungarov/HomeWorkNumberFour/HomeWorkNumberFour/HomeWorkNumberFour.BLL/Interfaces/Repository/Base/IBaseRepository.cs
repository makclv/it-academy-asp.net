using System.Collections.Generic;

namespace HomeWorkNumberFour.BLL.Interfaces.Repository.Base
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();

        void Create(TEntity entity);

        void AddOrUpdate(TEntity entity);

        void Delete(TEntity entity);
    }
}
