using System.Collections.Generic;
using System.Web.Mvc;

namespace HomeWorkNumberFour.BLL.Interfaces.Services
{
    public interface ICitiesListService
    {
        IEnumerable<SelectListItem> CityList();
    }
}
