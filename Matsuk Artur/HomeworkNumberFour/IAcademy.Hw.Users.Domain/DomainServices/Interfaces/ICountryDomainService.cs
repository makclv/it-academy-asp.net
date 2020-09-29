using ItAcademy.Hw.Users.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItAcademy.Hw.Users.Domain.DomainServices.Interfaces
{
   public interface ICountryDomainService
    {
        List<Country> GetCountries();
        Country GetCountry(int id);
        bool IsCityBelongsToCountry(int countryId, int cityId);
        Country GetCountryWithCities(int id);
    }
}
