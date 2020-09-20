using HomeWorkNumberFour.BLL.Interfaces.Repository;
using HomeWorkNumberFour.BLL.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HomeWorkNumberFour.BLL.Services
{
    public class CitiesListService : ICitiesListService
    {
        private ICitiesListRepository citiesListRepository;

        public CitiesListService(ICitiesListRepository citiesListRepository)
        {
            this.citiesListRepository = citiesListRepository;
        }

        public IEnumerable<SelectListItem> CityList()
        {
            var list = citiesListRepository.CityList()
                                           .Select(i => new SelectListItem()
                                           {
                                               Text = i.CityName,
                                               Value = i.CityName
                                           });

            return list;
        }
    }
}
