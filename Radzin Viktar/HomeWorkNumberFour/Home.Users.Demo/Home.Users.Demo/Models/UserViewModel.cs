using FluentValidation.Attributes;
using Home.Users.Demo.Domain.Entities;
using Home.Users.Demo.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home.Users.Demo.Models
{
    [Validator(typeof(UserValidator))]
    public class UserViewModel
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //public string Name { get { return FirstName + " " + LastName; }  }

        public string Phone { get; set; }

        public string Email { get; set; }

        public TitleViewModel Title { get; set; }

        public CountryViewModel Country { get; set; }

        public CityViewModel City { get; set; }

        public string Comments { get; set; }

        public IEnumerable<CountryViewModel> Countries { set; get; }

        public IEnumerable<CityViewModel> Cities { set; get; }
    }
}