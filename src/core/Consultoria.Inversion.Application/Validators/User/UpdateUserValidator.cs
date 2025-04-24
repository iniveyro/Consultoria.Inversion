using Consultoria.Inversion.Application.Database.User.Commands.UpdateUser;
using FluentValidation;

namespace Consultoria.Inversion.Application.Validators.User
{
    public class UpdateUserValidator : AbstractValidator<UpdateUserModel>
    {
        public UpdateUserValidator()
        {
            RuleFor(x=>x.UserId).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(x=>x.NombApe).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(x=>x.DNI).NotNull().NotEmpty();
            RuleFor(x=>x.Password).NotNull().NotEmpty().MinimumLength(8).MaximumLength(10);
            RuleFor(x=>x.Email).NotNull().NotEmpty().EmailAddress();
            RuleFor(x=>x.Tipo).NotNull().NotEmpty();
        }
    }
}