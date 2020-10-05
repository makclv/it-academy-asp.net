using HW4.Domain.DomainServices.Interfaces;
using HW4.Domain.Models;
using HW4.Domain.Repositories.Interfaces;
using HW4.Domain.UnitOfWork.Interfaces;
using System.Collections.Generic;

namespace HW4.Domain.DomainServices
{
    public class CountryDomainService : BaseDomainService, ICountryDomainService
    {
        private readonly ICountryRepository countryRepository;

        public CountryDomainService(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        public bool CheckingThePresenceOfCityInTheCountry(int countryId, int cityId)
        {
            return countryRepository.CheckingThePresenceOfCityInTheCountry(countryId, cityId);
        }

        public List<Country> GetAllCountries()
        {
            return countryRepository.GetAll();
        }

        public Country GetCountry(int id)
        {
            return countryRepository.Get(id);
        }
    }
}
