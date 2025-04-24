using Consultoria.Inversion.Application.Database.Inversion.Commands.CreateInversion;
using FluentValidation;

namespace Consultoria.Inversion.Application.Validators.Inversion
{
    public class CreateInversionValidator : AbstractValidator<CreateInversionModel>
    {
        public CreateInversionValidator()
        {
            RuleFor(x=>x.BrokerId).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(x=>x.FechaInicio).NotEmpty().NotNull();
            RuleFor(x=>x.FechaVencimiento).NotEmpty().NotNull();
            RuleFor(x=>x.Estado).NotEmpty().NotNull().MaximumLength(10);
            RuleFor(x=>x.Monto).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(x=>x.Nombre).NotEmpty().NotNull().MaximumLength(4);
            RuleFor(x=>x.Rendimiento).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(x=>x.Tipo).NotEmpty().NotNull().MaximumLength(20);
            RuleFor(x=>x.UserId).NotEmpty().NotNull().GreaterThan(0);
        }
    }
}