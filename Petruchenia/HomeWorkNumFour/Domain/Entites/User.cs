using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entites
{
    public class User
    {
        public int UserId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public Title UserTitle { get; set; }
        public Country UserCounty { get; set; }
        public Sity UserSity { get; set; }
        public string  Comment { get; set; }
    }

    public enum Title
    {
        Mr,
        Mrs,
        Miss,
        Dr
    }
}
