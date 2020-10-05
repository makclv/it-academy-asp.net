﻿using System.Collections.Generic;

namespace OrderTrackingSystem.Domain.Repositories
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

    }
}




