using Home.Users.Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home.Users.Demo.Models
{
    public class CityViewModel
    {
        public int CityId { get; set; }

        public string Name { get; set; }

        public List<UserViewModel> Users { get; set; }
    }
}