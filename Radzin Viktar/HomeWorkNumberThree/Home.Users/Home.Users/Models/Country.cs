using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Home.Users.Models
{
    public class Country
    {
        [Display(Name = "Country")]
        public string Name { get; set; }

        public Country() { }
        public Country(string Name) 
        {
            this.Name = Name;
        }
    }
}