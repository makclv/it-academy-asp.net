using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home.Users.Models
{
    public class StaticCountryList
    {
        public static IEnumerable<SelectListItem> CountryListItems()
        {
            var items = new List<SelectListItem>
        {
            new SelectListItem() {Text = "Belarus", Value = "Belarus"},
            new SelectListItem() {Text = "Russia", Value = "Russia"},
            new SelectListItem() {Text = "England", Value = "England"},
            new SelectListItem() {Text = "Montenegro", Value = "Montenegro"},
          
        };
            return items;
        }
    }
}