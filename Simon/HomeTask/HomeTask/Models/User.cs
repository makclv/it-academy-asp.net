using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeTask.Models
{

    public enum Title
    {
        Mr,
        Dr
    }

    public enum Country
    {
        RF,
        Rb
    }

    public enum City
    {
        Minsk,
        Homel
    }

    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Title Title { get; set; }

        public Country Country { get; set; }

        public City City { get; set; }

        public string Comments { get; set; }

    }
   
    
}