using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeTask.Models
{
    public class City
    {
        public int CityId { get; set; }

        public string СityName { get; set; }

        public Country Country { get; set; }
    }

}