using OrderTrackingSystem.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace OrderTrackingSystem.ViewModels.Users
{
    //[Validator(typeof(CreateUsersVmValidator))]
    public class CreateUsersViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [UIHint("MultilineText")]
        public string Comments { get; set; }

        public Title UserTitle { get; set; }

        public int CityId { get; set; }
        public int CountryId { get; set; }


        public SelectList SelectListCitys { get; set; }
        public SelectList SelectListCountries { get; set; }

    }
}