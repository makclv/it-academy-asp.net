using FluentValidation;
using Home.Users.Demo.Models;
using Home.Users.Demo.Services.Interfaces;

namespace Home.Users.Demo.Validators
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        private readonly IUserPresentationService userPresentationService;

        public UserValidator(IUserPresentationService userPresentationService) 
        {
            this.userPresentationService = userPresentationService;
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First Name is required.")
                .MaximumLength(20).WithMessage("First Name can have a max of 20 characters.")
                .Must(IsUniqueFirstName).WithMessage("This name already exists");
            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last Name is required.")
                .MaximumLength(20).WithMessage("Last Name can have a max of 20 characters.")
                .Must(IsUniqueLastName).WithMessage("This name already exists");
            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("First Name is required.")
                .MaximumLength(15).WithMessage("Phone can have a max of 15 characters.")
                .Must(IsUniquePhone).WithMessage("This phone already exists");
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .MaximumLength(25).WithMessage("Email can have a max of 20 characters.")
                .EmailAddress()
                .Must(IsUniqueMail).WithMessage("Mail already exists");
            RuleFor(x =>x.Title).NotEmpty().WithMessage("Title required");
            RuleFor(x=>x.Comments).
                MaximumLength(1000).WithMessage("Comments can have a max of 1000 characters.");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Country required");
            RuleFor(x => x.City).NotEmpty().WithMessage("Country required");
            RuleFor(x => x)
               .Must(ifCityOfCountry).WithMessage("This city not of  country.");
        }

        private bool IsUniqueFirstName(string firstname)
        {
            return userPresentationService.IsUniqueFirstName(firstname);
        }

        private bool IsUniqueLastName(string lastname)
        {
            return userPresentationService.IsUniqueLastName(lastname);
        }

        private bool IsUniquePhone(string phone) 
        {
            return userPresentationService.IsUniquePhone(phone);
        }

        private bool IsUniqueMail(string mail)
        {
            return userPresentationService.IsUniqueMail(mail);
        }

        private bool ifCityOfCountry(UserViewModel userViewModel)
        {
            return userPresentationService.ifCityOfCountry(userViewModel.Country.CountryId, userViewModel.City.CityId);
        }


    }
}