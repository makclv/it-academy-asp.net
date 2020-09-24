using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItAcademy.HomeWorkNumFour.Models.EntityFramework
{
    public class UserViewModel
    {
            public int UserId { get; set; }
            public string FName { get; set; }
            public string LName { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public ViewTitle Title { get; set; }
            public CountryViewModel Country { get; set; }
            public SityViewModel Sity { get; set; }
            public string Comment { get; set; }
        
    }

    public enum ViewTitle
    {
        Mr,
        Mrs,
        Miss,
        Dr
    }
}