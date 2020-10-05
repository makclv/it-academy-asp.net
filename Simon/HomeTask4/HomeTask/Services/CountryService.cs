using HomeTask.Models;
using HomeTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeTask.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        public List<Country> GetAllCountry()
        {
           return countryRepository.GetAllCountry();
        }

        public Country GetById(int id)
        {
            return countryRepository.GetById(id);
        }
    }
}