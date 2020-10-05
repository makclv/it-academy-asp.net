using FluentValidation.Attributes;
using HomeTask.Services.interfaces;
using HomeTask.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeTask.Models
{

    public enum Title
    {
        Mr,
        Dr
    }

    public class User
    {
        public int Id { get; set;}

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Title Title { get; set; }

        public int CountryId  { get; set; }

        public int CityId { get; set; }

        public string Comments { get; set; }

    }
}