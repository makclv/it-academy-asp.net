using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entites
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public List<City> Cities { get; set; }
        public List<User> Users { get; set; }
    }
}
