using FluentValidation;
using TallerDeBicicletasPro.Application.DTOs;

namespace TallerDeBicicletasPro.Application.Validators
{
    public class BicicletaValidator : AbstractValidator<BicicletaDto>
    {
        public BicicletaValidator()
        {
            RuleFor(x => x.Modelo)
                .NotEmpty().WithMessage("El modelo es obligatorio")
                .MaximumLength(100).WithMessage("El modelo no puede superar 100 caracteres");

            RuleFor(x => x.Color)
                .NotEmpty().WithMessage("El color es obligatorio")
                .MaximumLength(50).WithMessage("El color no puede superar 50 caracteres");

            RuleFor(x => x.Precio)
                .GreaterThan(0).WithMessage("El precio debe ser mayor que 0");
        }
    }
}
