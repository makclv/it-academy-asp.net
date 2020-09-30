using FluentValidation;
using ItAcademy.Hw.Users.Client.Models;
using ItAcademy.Hw.Users.Client.Util.Mappers;
using ItAcademy.Hw.Users.Domain.DomainServices.Interfaces;
using ItAcademy.Hw.Users.Domain.Models;
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

            RuleFor(x => x)

                .Must(IsUniquePhone).WithMessage("This number already exists")
            .Must(IsUniqueEmail).WithMessage("This email already exists")
             .Must(IsUniqueName).WithMessage("Full name already exist. Please enter other Name or Surname.");
             

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Please specify a phone.")
                .MaximumLength(30).WithMessage("Phone can have a max of 30 characters.");




            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Please specify an email.")
                .MaximumLength(30).WithMessage("Email can have a max of 30 characters.");
                

            RuleFor(x => x.Title)
                .NotNull().WithMessage("Please fill in the field.")
                .Must(NotZero).WithMessage("Select this");

            RuleFor(x => x.Comments)
                .MaximumLength(500).WithMessage("Comments can have a max of 500 characters.");

           
        }

       

        private bool IsUniqueName(CreateUserView userView)
        {
            return userDomainService.IsUniqueName(userView.Name, userView.Surname, userView.Id);
        }

        private bool IsUniqueEmail(CreateUserView userView)
        {
            return userDomainService.IsUniqueEmail(userView.Email, userView.Id);
        }

        private bool IsUniquePhone(CreateUserView userView)
        {
            return userDomainService.IsUniquePhone(userView.Phone, userView.Id);
        }

        private bool NotZero(Title title)
        {
            return title != 0;
        }
    }
}
    
