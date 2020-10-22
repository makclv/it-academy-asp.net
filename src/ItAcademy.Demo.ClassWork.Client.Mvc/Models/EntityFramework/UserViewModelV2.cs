using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using ItAcademy.Demo.ClassWork.Client.Mvc.Infrastructure.ValidationAttributes;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Models.EntityFramework
{
    [NoWhiteSpacesValidation(ErrorMessage = "First Name must not contain spaces.")]
    public class UserViewModelV2
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required.")]
        [MaxLength(10, ErrorMessage = "First Name can have a max of 10 characters.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required.")]
        [MaxLength(15, ErrorMessage = "Last Name can have a max of 15 characters.")]
        [Remote("NoWhiteSpacesValidate", "User", ErrorMessage = "Last Name must not contain spaces.")]
        public string LastName { get; set; }

        public string RoleName { get; set; }
    }
}