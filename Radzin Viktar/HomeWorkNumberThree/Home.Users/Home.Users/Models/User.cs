using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Home.Users.Models
{
    public enum Title

    {
        Mr,
        Dr,
        Ms

    }
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Title Title { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }

        public string Name
        {
            get { return FirstName + " " + LastName; }
        }
    }
}