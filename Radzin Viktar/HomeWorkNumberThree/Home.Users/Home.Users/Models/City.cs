using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Home.Users.Models
{
    public class City
    {
        [Display(Name = "City")]
        public string Name { get; set; }

        public City() { }

        public City(string Name) 
        {
            this.Name = Name;
        }
    }
}