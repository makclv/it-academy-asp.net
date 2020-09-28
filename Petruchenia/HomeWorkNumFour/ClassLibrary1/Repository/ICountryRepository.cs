using Domain.Entites;
using System.Collections.Generic;

namespace Domain.Repository
{
    public interface ICountryRepository : IBaseRepository<Country>
    {
        List<Country> GetAll();
    }
}
