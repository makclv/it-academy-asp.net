using FluentValidation;
using Home.Users.Demo.Models;
using Home.Users.Demo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home.Users.Demo.Validators
{
    public class UserEditValidator : AbstractValidator<UserEditViewModel>
    {
        private readonly IUserPresentationService userPresentationService;

        public UserEditValidator(IUserPresentationService userPresentationService)
        {
            this.userPresentationService = userPresentationService;
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First Name is required.")
                .MaximumLength(20).WithMessage("First Name can have a max of 20 characters.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last Name is required.")
                .MaximumLength(20).WithMessage("Last Name can have a max of 20 characters.");

            RuleFor(x => x.Phone)
               .NotEmpty().WithMessage("First Name is required.")
               .MaximumLength(15).WithMessage("Phone can have a max of 15 characters.");

            RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required.")
            .MaximumLength(25).WithMessage("Email can have a max of 20 characters.")
            .EmailAddress();

            RuleFor(x => x.TitleView).NotEmpty().WithMessage("Title required");
            RuleFor(x => x.Comments).
                MaximumLength(1000).WithMessage("Comments can have a max of 1000 characters.");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Country required");
            RuleFor(x => x.City).NotEmpty().WithMessage("Country required");
            RuleFor(x => x)
               .Must(ifCityOfCountry).WithMessage("This city not of  country.");
        }

        private bool ifCityOfCountry(UserEditViewModel userEditViewModel)
        {
            return userPresentationService.ifCityOfCountry(userEditViewModel.Country.CountryId, userEditViewModel.City.CityId);
        }
    }
}