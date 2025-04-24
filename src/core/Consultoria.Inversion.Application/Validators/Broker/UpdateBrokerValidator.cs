using Consultoria.Inversion.Application.Database.Broker.Commands.UpdateBroker;
using FluentValidation;

namespace Consultoria.Inversion.Application.Validators.Broker
{
    public class UpdateBrokerValidator : AbstractValidator<UpdateBrokerModel>
    {
        public UpdateBrokerValidator()
        {
            RuleFor(x=>x.BrokerId).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(x=>x.Certificacion).NotNull().NotEmpty().MaximumLength(3);
            RuleFor(x=>x.DNI).NotNull().NotEmpty();
            RuleFor(x=>x.Email).NotNull().NotEmpty().EmailAddress();
            RuleFor(x=>x.NombApe).NotNull().NotEmpty().MaximumLength(50);
        }
    }
}