using ClassLibrary1.Services.Interfaces;
using ItAcademy.HomeWorkNumFour.Service.Interface;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ItAcademy.HomeWorkNumFour.Service
{
    public class CountryPresentationService : ICountryPresentationService
    {
        private readonly ICountryDomainService countryDomainService;

        public CountryPresentationService(ICountryDomainService countryDomainService)
        {
            this.countryDomainService = countryDomainService;
        }

        public IEnumerable<SelectListItem> GetAllCountries()
        {
            return (IEnumerable<SelectListItem>)countryDomainService.GetAllCountries();
        }
    }
}