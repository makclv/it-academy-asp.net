 using Domain.Entites;
using ItAcademy.HomeWorkNumFour.Models.CRUD;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ItAcademy.HomeWorkNumFour.Models.EntityFramework
{
    public class CreateUser
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Title Title { get; set; }
        public int CountryId { get; set; }
        public ViewContext Country { get; set; }
        public int SityId { get; set; }
        public ViewSity Sity { get; set; }
        public string Comment { get; set; }

        public IEnumerable<SelectListItem> CountriesDDL { get; set; }
        public IEnumerable<SelectListItem> SitiesDDL { get; set; }
    }
}