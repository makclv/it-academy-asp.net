using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItAcademy.HomeWorkNumFour.Models.CRUD
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Title Title { get; set; }
        public ViewCountry Country { get; set; }
        public ViewSity Sity { get; set; }
        public string Comment { get; set; }
    }
}