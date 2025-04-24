using Consultoria.Inversion.Application.Database.Broker.Commands.CreateBroker;
using FluentValidation;

namespace Consultoria.Inversion.Application.Validators.Broker
{
    public class CreateBrokerValidator : AbstractValidator<CreateBrokerModel>
    {
        public CreateBrokerValidator()
        {
            RuleFor(x=>x.DNI).NotEmpty().NotNull();
            RuleFor(x=>x.Certificacion).NotEmpty().NotNull().MaximumLength(3);
            RuleFor(x=>x.Email).NotEmpty().NotNull().EmailAddress();
            RuleFor(x=>x.NombApe).NotEmpty().NotNull().MaximumLength(50);
        }
    }
}