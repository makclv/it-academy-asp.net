using FluentValidation;
using OrderTrackingSystem.Domain.DomainServices.Interfaces;
using OrderTrackingSystem.ViewModels.Users;

namespace OrderTrackingSystem.Validators
{

    public class CreateUsersVmValidator : AbstractValidator<CreateUsersViewModel> 
    {
        private readonly IUserDomainService userDomainService;
        private readonly ICityDomainService cityDomainService;
        private readonly ICountryDomainService countryDomainService;

        public CreateUsersVmValidator(IUserDomainService userDomainService, ICityDomainService cityDomainService, ICountryDomainService countryDomainService)
        {
            this.userDomainService = userDomainService;
            this.cityDomainService = cityDomainService;
            this.countryDomainService = countryDomainService;


            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("Please specify a first name.")
                .MaximumLength(15).WithMessage("First Name can have a max of 15 characters.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Please specify a first name.")
                .MaximumLength(15).WithMessage("Last Name can have a max of 15 characters.");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Please specify a phone.")
                .MaximumLength(30).WithMessage("Phone can have a max of 30 characters.")
                .Must(IsUniquePhone).WithMessage("This number already exists");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Please specify a phone.")
                .MaximumLength(30).WithMessage("Phone can have a max of 30 characters.")
                .Must(IsUniqueEmail).WithMessage("This email already exists");

            RuleFor(x => x.UserTitle).
                NotNull().WithMessage("Please fill in the field.");

            RuleFor(x => x.Comments).
                MaximumLength(500).WithMessage("Comments can have a max of 500 characters.");

            RuleFor(x => x.CityId)
                .Must(CityIdIsExists).WithMessage("The data entered is incorrect.");

            RuleFor(x => x.CountryId)
                .Must(CountryIdIsExists).WithMessage("The data entered is incorrect.");

            RuleFor(x => x)
                .Must(IsUniqueFullName).WithMessage("Full name already exist. Please enter other First name or Last name.");

            RuleFor(x => x)
                .Must(IsCityBelongsCountry).WithMessage("This city does not belong to the selected country.");
        }

        private bool CityIdIsExists(int cityId)
        {
            return cityDomainService.CityIdIsExists(cityId);
        }

        private bool CountryIdIsExists(int countryId)
        {
            return countryDomainService.CountryIdIsExists(countryId);
        }



        private bool IsCityBelongsCountry(CreateUsersViewModel usersViewModel)
        {
            return userDomainService.IsCityBelongsCountry(usersViewModel.CountryId, usersViewModel.CityId);
        }

        private bool IsUniqueFullName(CreateUsersViewModel usersViewModel)
        {
            return userDomainService.IsUniqueFullName($"{usersViewModel.FirstName}+{usersViewModel.LastName}");
        }

        private bool IsUniqueEmail(string email)
        {
            return userDomainService.IsUniqueEmail(email);
        }

        private bool IsUniquePhone(string phone)
        {
            return userDomainService.IsUniquePhone(phone);
        }
    }
}