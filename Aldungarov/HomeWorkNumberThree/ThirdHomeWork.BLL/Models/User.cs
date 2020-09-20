using System.Collections.Generic;
using ThirdHomeWork.BLL.Enum;

namespace ThirdHomeWork.BLL.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Title Title { get; set; }

        public Address Address { get; set; }

        public string Comments { get; set; }

        public List<Country> CountryList { get; set; }

        public List<City> CityList { get; set; }
    }
}
