using System.Collections.Generic;
using System.Linq;

namespace HW4.Domain.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T item);
        T Get(int id);
        void Delete(T item);
        void DeleteById(int itemId);
        List<T> GetAll();
    }
}
