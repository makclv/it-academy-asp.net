using HW4.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace HW4.Client.Models.ViewModels
{
    public class AllUsersViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Title UserTitle { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}