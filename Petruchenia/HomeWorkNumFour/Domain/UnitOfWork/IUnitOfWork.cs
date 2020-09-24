using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace Domain.IUnitOfWork
{
    public interface IUnitOfWork
    {
        DbSet<TEntity> Set<TEntity>()
            where TEntity : class;
    }
}
