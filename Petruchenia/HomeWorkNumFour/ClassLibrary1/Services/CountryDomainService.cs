using ClassLibrary1.Services.Interfaces;
using Domain.Entites;
using Domain.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ClassLibrary1.Services
{
    public class CountryDomainService : ICountryDomainService
    {
        private readonly ICountryRepository countryRepository;

        public CountryDomainService (ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        public SelectList GetAllCountries()
        {
            List<Country> countries = countryRepository.GetAll();
            var listItems = new SelectList(countries, "CountryId", "CountryName");
            return listItems;
        }


        public Country GetCountryById(int id)
        {
            return countryRepository.GetCountryById(id);
        }

        public bool AreCityBelongToCountry(int countryId, int cityId)
        {
            return countryRepository
                .GetCountryWithCities(countryId).Cities.Any(x => x.CityId.Equals(cityId));
        }
    }
}
