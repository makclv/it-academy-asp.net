using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItAcademy.HomeWorkNumFour.Models.EntityFramework
{
    public class EditUser
    {
        public int UserId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Title Title { get; set; }
        public string Country { get; set; }
        public string Sity { get; set; }
        public string Comment { get; set; }

        public IEnumerable<SelectListItem> CountriesDDL { get; set; }
        public IEnumerable<SelectListItem> SitiesDDL { get; set; }
    }
}