using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entites
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public Country Country { get; set; }
        public List<User> Users { get; set; }
    }
}
