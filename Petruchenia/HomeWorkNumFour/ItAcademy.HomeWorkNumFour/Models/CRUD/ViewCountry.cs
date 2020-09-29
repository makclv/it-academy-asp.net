using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItAcademy.HomeWorkNumFour.Models.CRUD
{
    public class ViewCountry
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public List<ViewCity> Cities { get; set; }
        public List<UserViewModel> Users { get; set; }
    }
}