using Consultoria.Inversion.Application.Database.User.Commands.CreateUser;
using FluentValidation;

namespace Consultoria.Inversion.Application.Validators.User
{
    public class CreateUserValidator : AbstractValidator<CreateUserModel>
    {
        public CreateUserValidator()
        {
            RuleFor(x=>x.NombApe).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(x=>x.DNI).NotNull().NotEmpty();
            RuleFor(x=>x.Password).NotNull().NotEmpty().MinimumLength(8).MaximumLength(10);
            RuleFor(x=>x.Email).NotNull().NotEmpty().EmailAddress();
            RuleFor(x=>x.Tipo).NotNull().NotEmpty();
        }
    }
}