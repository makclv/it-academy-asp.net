using System.Collections.Generic;
using ThirdHomeWork.BLL.Enum;
using ThirdHomeWork.BLL.Models;

namespace ThirdHomeWork.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string FIO { get; set; }

        public Title Title { get; set; }

        public string CountryName { get; set; }

        public string CityName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Comments { get; set; }

        public List<Country> CountryList { get; set; }
        
        public List<City> CityList { get; set; }
    }
}
