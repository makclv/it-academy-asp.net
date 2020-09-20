using HomeWorkNumberFour.BLL.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HomeWorkNumberFour.BLL.Interfaces.Repository
{
    public interface ICountriesListRepository
    {
        //IEnumerable<SelectListItem> CountriesList();
        List<Country> CountriesList();
    }
}
