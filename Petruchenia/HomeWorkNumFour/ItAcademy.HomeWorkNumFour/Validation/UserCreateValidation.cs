using ClassLibrary1.Services.Interfaces;
using FluentValidation;
using ItAcademy.HomeWorkNumFour.Models.EntityFramework;

namespace ItAcademy.HomeWorkNumFour.Validation
{
    public class UserCreateValidation : AbstractValidator<CreateUser>
    {        
        private readonly IUserDomainService userDomainService;
        private readonly ICountryDomainService countryDomainService;
        public UserCreateValidation(IUserDomainService userDomainService, ICountryDomainService countryDomainService)
        {
            this.countryDomainService = countryDomainService;
            this.userDomainService = userDomainService;

            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("Please specify a Name.")
                .MaximumLength(15).WithMessage("You First Name can't be much then 15 simbols");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Please specify a Name.")
                .MaximumLength(15).WithMessage("You Last Name can't be much then 15 simbols");
            
            RuleFor(x => x.Comment).
                MaximumLength(300).WithMessage("You comment much then 300 simbols");
            
            RuleFor(x => x.Title).
                NotNull().WithMessage("Please fill in the field.");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Please specify a phone.")
                .MaximumLength(11).WithMessage("You Phone can't be much then 11 simbols")
                .Must(IsUniquePhone).WithMessage("This number already exists");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Please specify a phone.")
                .MaximumLength(30).WithMessage("You Email can't be much then 30 simbols")
                .Must(IsUniqueEmail).WithMessage("This email already exists");


            //RuleFor(x => x)
            //    .Must(IsUniqueName).WithMessage("This Name already exist.");

            ////RuleFor(x => x)
            //    .Must(IsCityBelongsToCountry).WithMessage("This city are not belogn to selected country");


        }

        private bool IsUniqueName(CreateUser createUser)
        {
            return userDomainService.IsUniqueName(createUser.FirstName, createUser.LastName);
        }

        private bool IsUniqueEmail(string email)
        {
            return userDomainService.IsUniqueEmail(email);
        }

        private bool IsUniquePhone(string phone)
        {
            return userDomainService.IsUniquePhone(phone);
        }

        private bool IsCityBelongsToCountry(CreateUser createUser)
        {
            return countryDomainService.AreCityBelongToCountry(createUser.Country.CountryId, createUser.City.CityId);
        }
    }
}

