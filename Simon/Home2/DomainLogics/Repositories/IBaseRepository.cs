using DomainLogics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogics.Repositories
{
    public interface IBaseRepository<TModel>
    {
        void Add(TModel model);
    }
}
