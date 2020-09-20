using System.Collections.Generic;
using System.Web.Mvc;

namespace HomeWorkNumberFour.BLL.Interfaces.Repository
{
    public interface ICountriesListService
    {
        IEnumerable<SelectListItem> CountriesList();
    }
}