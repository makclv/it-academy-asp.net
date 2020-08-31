using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home.Users.Models
{
    public class StaticCityList
    {
        public static IEnumerable<SelectListItem> CityListItems()
        {
            var items = new List<SelectListItem>
        {
            new SelectListItem() {Text = "Minsk", Value = "Minsk"},
            new SelectListItem() {Text = "Moscow", Value = "Moscow"},
            new SelectListItem() {Text = "London", Value = "London"},
            new SelectListItem() {Text = "Podgorica", Value = "Podgorica"},
          
        };
            return items;
        }
    }
}