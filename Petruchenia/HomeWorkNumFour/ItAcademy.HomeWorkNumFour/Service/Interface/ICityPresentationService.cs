using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ItAcademy.HomeWorkNumFour.Service.Interface
{
    public interface ICityPresentationService
    {
        IEnumerable<SelectListItem> GetAllCities();
    }
}
