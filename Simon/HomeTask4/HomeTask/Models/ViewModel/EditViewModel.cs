using FluentValidation.Attributes;
using HomeTask.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeTask.Models.ViewModel
{
    public class EditViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Title Title { get; set; }

        public List<Country> Countrys { get; set; }

        public List<City> Citys { get; set; }

        public int CityId { get; set; }

        public int CountryId { get; set; }

        public string Comments { get; set; }
    }
}