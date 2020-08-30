using System.Collections.Generic;
using System.Web.Mvc;

namespace ThirdHomeWork.BLL.Models
{
    public static class CountryList
    {
        public static IEnumerable<SelectListItem> GetCountryList()
        {
            var countries = new List<SelectListItem>
            {
                new SelectListItem() {Text = "USA", Value = "USA"},
                new SelectListItem() {Text = "Russia", Value = "Russia"},
                new SelectListItem() {Text = "England", Value = "England"},
                new SelectListItem() {Text = "Hells Bells", Value = "Hells Bells", Selected = true},
            };

            return countries;
        }
    }
}
