using FluentValidation;
using HomeTask.Models;
using HomeTask.Models.ViewModel;
using HomeTask.Services.interfaces;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace HomeTask.Validation
{
    public class EditValidation : AbstractValidator<EditViewModel>
    {
        public IUsersService usersService;
        public ICityService cityService;

        public EditValidation(IUsersService usersService, ICityService cityService)
        {
            this.cityService = cityService;
            this.usersService = usersService;
            RuleFor(x => x.Id)
               .NotNull()
               .Must(VerificationUserId);


            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name required")
           .Length(3, 20).WithMessage("first name can have 3-20  letters")
           .Matches("^[a-zA-Z_]*$").WithMessage("Only letters");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name required")
                .Length(3, 20).WithMessage("last name can have 3-20  letters")
                .Matches("^[a-zA-Z_]*$").WithMessage("Only letters");

            RuleFor(x => x.FirstName + " " + x.LastName).Custom((FullName, context) =>
            {
                if (FullName.Split(' ')[0] == FullName.Split(' ')[1])
                {
                    context.AddFailure("First name last name must not match");
                }
            });

            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone required")
                .Matches("^[0-9_]*$").WithMessage("Only numbers")
                .Must(IsUniquePhone).WithMessage("Such a phone already exists");

            RuleFor(x => x.Email).NotEmpty().WithMessage("email required")
               .Must(IsUniqueEmail).WithMessage("Such a email already exists");
            }
        private bool IsUniqueEmail(string email)
        {
            return usersService.IsUniqueEmail(email);

        }

        private bool IsUniquePhone(string phone)
        {
            return usersService.IsUniquePhone(phone);

        }

        private bool VerificationUserId(int userId)
        {
            return usersService.VerificationUserId(userId);

        }
    }
}