using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItAcademy.HomeWorkNumFour.Models.CRUD
{
    public class ViewCity
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public ViewCountry Country { get; set; }
        public List<UserViewModel> Users { get; set; }
    }
}