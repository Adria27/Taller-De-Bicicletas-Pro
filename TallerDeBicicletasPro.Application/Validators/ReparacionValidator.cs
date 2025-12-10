using FluentValidation;
using TallerDeBicicletasPro.Application.DTOs;

namespace TallerDeBicicletasPro.Application.Validators
{
    public class ReparacionValidator : AbstractValidator<ReparacionDto>
    {
        public ReparacionValidator()
        {
            RuleFor(x => x.Descripcion)
                .NotEmpty().WithMessage("La descripción es obligatoria.")
                .MinimumLength(5).WithMessage("La descripción debe tener al menos 5 caracteres.")
                .MaximumLength(200).WithMessage("La descripción no puede exceder los 200 caracteres.");

            RuleFor(x => x.Costo)
                .GreaterThan(0).WithMessage("El costo debe ser mayor a 0.");

            RuleFor(x => x.FechaEntrada)
                .NotEmpty().WithMessage("La fecha de entrada es obligatoria.");

            RuleFor(x => x.FechaSalida)
                .GreaterThan(x => x.FechaEntrada)
                .When(x => x.FechaSalida.HasValue)
                .WithMessage("La fecha de salida debe ser mayor que la fecha de entrada.");
        }
    }
}
