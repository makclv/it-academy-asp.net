using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeTask.Models
{
    public class Country
    {
        public int CountryId { get; set; }

        public string CountryName { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}