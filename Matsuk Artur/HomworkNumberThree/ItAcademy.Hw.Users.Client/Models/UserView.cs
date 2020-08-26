using ItAcademy.Hw.Users.Data.Models;
using ItAcademy.Hw.Users.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ItAcademy.Hw.Users.Client.Models
{
    public class UserView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }      
        public Country Country { get; set; }
        public City City { get; set; } 
        public Title Title { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }
    }
}