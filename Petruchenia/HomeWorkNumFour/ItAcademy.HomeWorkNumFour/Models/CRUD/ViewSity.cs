using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItAcademy.HomeWorkNumFour.Models.CRUD
{
    public class ViewSity
    {
        public int SityId { get; set; }
        public string SityName { get; set; }
        public ViewCountry Country { get; set; }
        public List<UserViewModel> Users { get; set; }
    }
}