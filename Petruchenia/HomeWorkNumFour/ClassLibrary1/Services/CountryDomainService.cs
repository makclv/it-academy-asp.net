using ClassLibrary1.Services.Interfaces;
using Domain.Entites;
using Domain.Repository;
using System.Collections.Generic;

namespace ClassLibrary1.Services
{
    public class CountryDomainService : ICountryDomainService
    {
        private readonly ICountryRepository countryRepository; 
        public CountryDomainService (ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        public List<User> GetUsersByCountry(string country)
        {
            return countryRepository.GetUsersByCountry(country);
        }
    }
}
