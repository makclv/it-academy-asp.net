using HomeWorkNumberFour.BLL.Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HomeWorkNumberFour.BLL.Services
{
    public class CountriesListService : ICountriesListService
    {
        private ICountriesListRepository countriesListRepository;

        public CountriesListService(ICountriesListRepository countriesListRepository)
        {
            this.countriesListRepository = countriesListRepository;
        }

        public IEnumerable<SelectListItem> CountriesList()
        {
            var list = countriesListRepository.CountriesList()
                                              .Select(i => new SelectListItem()
                                              {
                                                  Text = i.CountryName,
                                                  Value = i.CountryName
                                              });
            return list;
        }
    }
}
