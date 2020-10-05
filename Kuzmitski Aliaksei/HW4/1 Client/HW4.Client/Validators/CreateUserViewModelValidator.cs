using FluentValidation;
using HW4.Client.Models.ViewModels;
using HW4.Domain.DomainServices.Interfaces;

namespace HW4.Client.Validators
{
    public class CreateUserViewModelValidator : AbstractValidator<CreateUserViewModel>
    {
        private readonly IUserDomainService userDomainService;
        private readonly ICountryDomainService countryDomainService;

        public CreateUserViewModelValidator(IUserDomainService userDomainService, ICountryDomainService countryDomainService)
        {
            this.userDomainService = userDomainService;
            this.countryDomainService = countryDomainService;

            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("Please specify a First Name.")
                .MaximumLength(20).WithMessage("First Name can have a maximum of 20 characters.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Please specify a Last Name.")
                .MaximumLength(30).WithMessage("Last Name can have a maximum of 30 characters.");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Please specify a Phone Number.")
                .MaximumLength(15).WithMessage("Phone Number can have a maximum of 15 characters.")
                .Must(UniquenessOfPhone).WithMessage("This Phone Number already exists");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Please specify a Email.")
                .MaximumLength(30).WithMessage("Email can have a maximum of 30 characters.")
                .Must(UniquenessOfEmail).WithMessage("This Email already exists");

            RuleFor(x => x.UserTitle).
                NotEmpty().WithMessage("Please fill Title field.");

            RuleFor(x => x.Comments).
                MaximumLength(300).WithMessage("Field Comments can have a maximum of 300 characters.");

            RuleFor(x => x)
                .Must(UniquenessOfFullName).WithMessage("Full Name already exists. Please modify First Name or Last Name.")
                .Must(CheckingThePresenceOfCityInTheCountry).WithMessage("This City is not in this Country");
        }

        private bool UniquenessOfFullName(CreateUserViewModel createUserViewModel)
        {
            return userDomainService.UniquenessOfFullName(0, createUserViewModel.FirstName, createUserViewModel.LastName);
        }

        private bool UniquenessOfPhone(CreateUserViewModel createUserViewModel, string phone)
        {
            return userDomainService.UniquenessOfPhone(0, phone);
        }

        private bool UniquenessOfEmail(CreateUserViewModel createUserViewModel, string email)
        {
            return userDomainService.UniquenessOfEmail(0, email);
        }

        private bool CheckingThePresenceOfCityInTheCountry(CreateUserViewModel createUserViewModel)
        {
            return countryDomainService.CheckingThePresenceOfCityInTheCountry(createUserViewModel.CountryId, createUserViewModel.CityId);
        }
    }
}