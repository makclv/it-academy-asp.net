using OrderTrackingSystem.Domain.Models;
using System.Collections.Generic;

namespace OrderTrackingSystem.Domain.Repositories
{
    public interface ICountryRepository : IBaseRepository<Country>
    {
        Country GetCountryWithCities(object id);
        bool IsExistsCountry(int id);
    }
}
