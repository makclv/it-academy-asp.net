using OrderTrackingSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderTrackingSystem.ViewModels.Users  
{
    public class CreateUsersViewModel
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [UIHint("MultilineText")]
        public string Comments { get; set; }

        public Title Title { get; set; }

         public Guid CityId { get; set; }
         public Guid CountryId { get; set; }

    }
}