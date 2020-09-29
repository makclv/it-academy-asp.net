using FluentValidation;
using ItAcademy.Hw.Users.Client.Models;
using ItAcademy.Hw.Users.Client.Util.Mappers;
using ItAcademy.Hw.Users.Domain.DomainServices.Interfaces;
using System;

namespace ItAcademy.Hw.Users.Client.Validators
{
    public class CreateUserValidator : AbstractValidator<CreateUserView>
    {
        private readonly IUserDomainService userDomainService;

        public CreateUserValidator(IUserDomainService userDomainService)
        {
            this.userDomainService = userDomainService;

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Please specify a Name.")
                .MaximumLength(15).WithMessage("Name can have a max of 15 characters.");

            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Please specify a Name.")
                .MaximumLength(15).WithMessage("Surname can have a max of 15 characters.");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Please specify a phone.")
                .MaximumLength(30).WithMessage("Phone can have a max of 30 characters.")
                .Must(IsUniquePhone).WithMessage("This number already exists");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Please specify an email.")
                .MaximumLength(30).WithMessage("Email can have a max of 30 characters.")
                .Must(IsUniqueEmail).WithMessage("This email already exists");

            RuleFor(x => x.Title)
                .NotNull().WithMessage("Please fill in the field.");

            RuleFor(x => x.Comments)
                .MaximumLength(500).WithMessage("Comments can have a max of 500 characters.");

            RuleFor(x => x)
                .Must(IsUniqueName).WithMessage("Full name already exist. Please enter other Name or Surname.");

            RuleFor(x => x)
                .Must(IsCityBelongsToCountry).WithMessage("This city does not belong to the selected country.");
        }

        private bool IsCityBelongsToCountry(CreateUserView userView)
        {
            return userDomainService.IsCityBelongsToCountry(userView.CountryId, userView.CityId);
        }

        private bool IsUniqueName(CreateUserView userView)
        {
            return userDomainService.IsUniqueName(userView.Name, userView.Surname);
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
    
