using ItAcademy.Hw.Users.Domain.DomainServices.Interfaces;
using ItAcademy.Hw.Users.Domain.Models;
using ItAcademy.Hw.Users.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItAcademy.Hw.Users.Domain.DomainServices
{
   public class CountryDomainService : ICountryDomainService
    {
        private readonly ICountryRepository countryRepository;

        public CountryDomainService(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        public List<Country> GetCountries()
        {
            return countryRepository.GetAll();
        }

        public Country GetCountry(int id)
        {
            return countryRepository.Get(id);
        }

        public Country GetCountryWithCities(int id)
        {
            return countryRepository.GetCountryWithCities(id);

        }

       
    }
}
