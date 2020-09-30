using FluentValidation;
using HomeTask.Date;
using HomeTask.Models;
using HomeTask.Models.ViewModel;
using HomeTask.Services;
using HomeTask.Services.interfaces;
using System.Linq;

namespace HomeTask.Validation
{
    public class CreateValidation : AbstractValidator<CreateViewModel>
    {
            public IUsersService usersService;
            public ICityService cityService;
            public ICountryService countryService;
        public CreateValidation(IUsersService usersService, ICityService cityService, ICountryService countryService)
        {
            this.countryService = countryService;
            this.cityService = cityService;
            this.usersService = usersService;
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("first name required")
           .Length(3, 20).WithMessage("first name can have 3-20  letters")
           .Matches("^[a-zA-Z_]*$").WithMessage("Only letters");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("last name required")
                .Length(3, 20).WithMessage("last name can have 3-20  letters")
                .Matches("^[a-zA-Z_]*$").WithMessage("Only letters");

            RuleFor(x => x.FirstName + " " + x.LastName).Custom((FullName, context) =>
            {
                if (FullName.Split(' ')[0] == FullName.Split(' ')[1])
                {
                    context.AddFailure("first name last name must not match");
                }
            });

            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone required")
                .Matches("^[0-9_]*$").WithMessage("Only numbers")
                .Custom((phone, context) =>
                {
                    if (usersService.GetAllUsers().Select(x => x.Phone).Contains(phone))
                    {
                        context.AddFailure("such a phone already exists ");
                    }
                });

            RuleFor(x => x.Email).NotEmpty().WithMessage("email required")
               .Custom((email, context) =>
               {
                   if (usersService.GetAllUsers().Select(x => x.Email).Contains(email))
                   {
                       context.AddFailure("such a email already exists ");
                   }
               });

            //RuleFor(x => x).Custom((User, context) =>
            //{
            //    var r = countryService.GetAllCountry();
                
            //    var r1 = r.Single(x => x.Cities.Select(y => y.CityId).Contains(User.CityId));
            //    var r2 = r1.CountryId == User.Id;
            //    var e = cityService.GetAllCity();
            //    var e1 = e.Single(x => x.CityId == User.CityId);
            //    var e2 = e1.Country.CountryId != User.CountryId;
            //    if (e2)
            //    {
            //        context.AddFailure("");
            //    }
            //});
        }
      
    }
}