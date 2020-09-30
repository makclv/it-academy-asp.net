using Domain.Entites;
using System.Collections.Generic;

namespace Domain.Repository
{
    public interface ICountryRepository : IBaseRepository<Country>
    {
        List<Country> GetAll();
        Country GetCountryById(int id);
        Country GetCountryWithCities(int id);
    }
}
