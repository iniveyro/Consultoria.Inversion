using FluentValidation;

namespace Consultoria.Inversion.Application.Validators.User
{
    public class GetUserByEmailPasswordValidator : AbstractValidator<(string,string)>
    {
        public GetUserByEmailPasswordValidator()
        {
            RuleFor(x=>x.Item1).NotEmpty().NotNull().EmailAddress();
            RuleFor(x=>x.Item2).NotEmpty().NotNull();
        }        
    }
}