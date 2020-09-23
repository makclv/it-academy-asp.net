using OrderTrackingSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrderTrackingSystem.ViewModels.Users
{
    public class GetUsersViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Title Title { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
       
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        

        

    }
}