using FluentValidation.Attributes;
using ItAcademy.HomeWorkNumFour.Models.CRUD;
using ItAcademy.HomeWorkNumFour.Validation;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ItAcademy.HomeWorkNumFour.Models.EntityFramework
{
    [Validator(typeof(UserValidation))]
    public class CreateUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Title Title { get; set; }
        public int CountryId { get; set; }
        public ViewCountry Country { get; set; }
        public int CityId { get; set; }
        public ViewCity City { get; set; }
        public string Comment { get; set; }

        public IEnumerable<SelectListItem> CountriesDDL { get; set; }
        public IEnumerable<SelectListItem> CitiesDDL { get; set; }
    }
}