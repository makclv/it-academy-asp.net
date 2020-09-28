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
            List<Country> sities = countryRepository.GetAll();
            var listItems = new SelectList(sities, "CountryId", "CountryName");
            return listItems;
        }
    }
}
