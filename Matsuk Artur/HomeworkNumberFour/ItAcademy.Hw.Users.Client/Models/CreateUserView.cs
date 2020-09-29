using ItAcademy.Hw.Users.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItAcademy.Hw.Users.Client.Models
{
    public class CreateUserView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public Title Title { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }

        public int CityId { get; set; }
        public int CountryId { get; set; }

        public SelectList SelectListCities { get; set; }
        public SelectList SelectListCountries { get; set; }
    }
}