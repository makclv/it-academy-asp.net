using HomeWorkNumberFour.BLL.Enum;
using HomeWorkNumberFour.BLL.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HomeWorkNumberFour.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Title Title2 { get; set; }

        public string CountryName { get; set; }

        public string CityName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Comments { get; set; }

        public List<Country> CountryList { get; set; }

        public List<City> CityList { get; set; }

        public IEnumerable<SelectListItem> CountriesList { get; set; }
        
        public IEnumerable<SelectListItem> CitiesList { get; set; }
    }
}