using Domain.Entites;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ClassLibrary1.Services.Interfaces
{
    public interface ICityDomainService : IBaseDomainService
    {
        SelectList GetAllCities();
        City GetCityById(int id);
        bool IsCityBelongsToCountry(Country country);
    }
}
