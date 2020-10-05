using OrderTrackingSystem.Domain.Models;
using System.Collections.Generic;

namespace OrderTrackingSystem.Domain.DomainServices.Interfaces
{
    public interface ICityDomainService : IBaseDomainService
    {
        List<City> GetCitys();
        City GetCity(int id);
        City GetCityWithCountry(int id);
        bool CityIdIsExists(int cityId);
    }
}
