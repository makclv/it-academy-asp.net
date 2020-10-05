using HW4.Domain.Models;
using System.Collections.Generic;

namespace HW4.Domain.DomainServices.Interfaces
{
    public interface ICountryDomainService : IBaseDomainService
    {
        List<Country> GetAllCountries();
        Country GetCountry(int id);
        bool CheckingThePresenceOfCityInTheCountry(int countryId, int cityId);
    }
}
