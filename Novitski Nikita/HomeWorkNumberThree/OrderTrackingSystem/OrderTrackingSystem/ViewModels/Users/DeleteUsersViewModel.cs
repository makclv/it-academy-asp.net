using OrderTrackingSystem.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace OrderTrackingSystem.ViewModels.Users
{
    public class DeleteUsersViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [UIHint("MultilineText")]
        public string Comments { get; set; }

        public Title UserTitle { get; set; }

        public City City { get; set; }
        public Country Country { get; set; }
    }
}