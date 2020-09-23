using OrderTrackingSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTrackingSystem.Domain.DomainServices.Interfaces
{
    public interface ICountryDomainService : IBaseDomainService
    {
        List<Country> GetCountrys();
        Country GetCountryWithCities(int id);
        Country GetCountry(int id);
        bool IsCityBelongsCountry(int countryId, int cityId);
        bool CountryIdIsExists(int countryId);
    }
}
