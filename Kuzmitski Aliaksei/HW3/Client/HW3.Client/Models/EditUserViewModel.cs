using HW3.Domain.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace HW3.Client.Models
{
    public class EditUserViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Title Title { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }


        public Guid CountryId { get; set; }

        public Guid CityId { get; set; }

    }
}