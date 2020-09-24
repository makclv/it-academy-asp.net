using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItAcademy.HomeWorkNumFour.Models.EntityFramework
{
    public class CountryViewModel
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public List<SityViewModel> Sities { get; set; }
        public List<UserViewModel> Users { get; set; }
    }
}