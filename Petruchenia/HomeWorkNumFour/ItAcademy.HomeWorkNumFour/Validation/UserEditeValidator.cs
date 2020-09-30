using ClassLibrary1.Services.Interfaces;
using FluentValidation;
using ItAcademy.HomeWorkNumFour.Models.EntityFramework;

namespace ItAcademy.HomeWorkNumFour.Validation
{
    public class UserEditeValidator : AbstractValidator<EditUser>
    {
        private readonly ICountryDomainService countryDomainService;
        public UserEditeValidator(ICountryDomainService countryDomainService)
        {
            this.countryDomainService = countryDomainService;

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
                .MaximumLength(11).WithMessage("You Phone can't be much then 11 simbols");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Please specify a phone.")
                .MaximumLength(30).WithMessage("You Email can't be much then 30 simbols");

            RuleFor(x => x.CountryId).
               NotNull().WithMessage("Please fill in the field.");
            RuleFor(x => x.CityId).
               NotNull().WithMessage("Please fill in the field.");

            RuleFor(x => x)
                .Must(IsCityBelongsToCountry).WithMessage("This city are not belogn to selected country");

        }

        private bool IsCityBelongsToCountry(EditUser editUser)
        {
            return countryDomainService.AreCityBelongToCountry(editUser.CountryId, editUser.CityId);
        }
    }
}