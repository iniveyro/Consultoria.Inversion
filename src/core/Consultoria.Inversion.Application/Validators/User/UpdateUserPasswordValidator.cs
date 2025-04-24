using Consultoria.Inversion.Application.Database.User.Commands.UpdateUserPassword;
using FluentValidation;

namespace Consultoria.Inversion.Application.Validators.User
{
    public class UpdateUserPasswordValidator : AbstractValidator<UpdateUserPasswordModel>
    {
        public UpdateUserPasswordValidator()
        {
            RuleFor(x=>x.Password).NotEmpty().NotNull().MinimumLength(8).MaximumLength(10);
            RuleFor(x=>x.UserId).NotEmpty().NotNull().GreaterThan(0);
        }        
    }
}