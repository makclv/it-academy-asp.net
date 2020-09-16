using HW3.Domain.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace HW3.Client.Models
{
    public class AllUsersViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Title Title { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }


        public Country Country { get; set; }

        public City City { get; set; }
    }
}