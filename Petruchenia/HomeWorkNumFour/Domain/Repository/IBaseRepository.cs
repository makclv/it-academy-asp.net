using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        int Count();
        void Create(T item);
        void Delete(T item);
        T Get(object Id);
    }
}
