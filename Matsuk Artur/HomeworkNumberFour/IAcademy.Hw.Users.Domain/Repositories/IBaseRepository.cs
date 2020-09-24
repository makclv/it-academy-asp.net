using ItAcademy.Hw.Users.Domain.Models;

using System.Collections.Generic;
using System.Linq;

namespace ItAcademy.Hw.Users.Domain.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        int Count();
        void Add(T item);
        List<T> GetAll();
        void Delete(T item);
        void DeleteById(object itemId);
        T Get(object id);
        T Create();
        IQueryable<T> GetQueryableItems();

    }
}
