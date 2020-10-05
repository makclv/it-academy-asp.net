using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeTask.Models.ViewModel
{
    public enum Title
    {
        Mr,
        Dr
    }

    public class UserViewModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Title Title { get; set; }

        public int CountryId { get; set; }

        public int CityId { get; set; }

        public string Comments { get; set; }
    }
}