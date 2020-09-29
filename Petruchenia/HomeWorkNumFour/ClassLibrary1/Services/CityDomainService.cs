using ClassLibrary1.Services.Interfaces;
using Domain.Entites;
using Domain.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ClassLibrary1.Services
{
    public class CityDomainService : ICityDomainService
    {
        private readonly ICityRepository cityRepository;

        public CityDomainService (ICityRepository sityRepository)
        {
            this.cityRepository = sityRepository;
        }
        public SelectList GetAllCities()
        {
            List<City> cities = cityRepository.GetAll();
            var listItems = new SelectList(cities, "CityId", "CityName");
            return listItems;
        }

        public City GetCityById(int id)
        {
            return cityRepository.GetCityById(id);
        }

        public bool IsCityBelongsToCountry(Country country)
        {
            throw new System.NotImplementedException();
        }
    }
}
