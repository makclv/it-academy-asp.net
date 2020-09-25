using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Users.Demo.Domain.Entities
{
    public class Country
    {
        public int CountryId { get; set; }

        public string Name { get; set; }

        public List<User> Users { get; set; }

    }
}
