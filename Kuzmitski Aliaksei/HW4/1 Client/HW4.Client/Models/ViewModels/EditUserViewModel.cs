using HW4.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace HW4.Client.Models.ViewModels
{
    public class EditUserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Title UserTitle { get; set; }
        public int CountryId { get; set; }
        public SelectList ListOfCountries { get; set; }
        public int CityId { get; set; }
        public SelectList ListOfCities { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }
    }
}