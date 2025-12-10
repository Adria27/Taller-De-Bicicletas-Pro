using FluentValidation;
using TallerDeBicicletasPro.Application.DTOs;

namespace TallerDeBicicletasPro.Application.Validators
{
    public class MecanicoValidator : AbstractValidator<MecanicoDto>
    {
        public MecanicoValidator()
        {
            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage("El nombre del mecánico es obligatorio.")
                .MinimumLength(3).WithMessage("El nombre debe tener al menos 3 caracteres.")
                .MaximumLength(60).WithMessage("El nombre no puede exceder los 60 caracteres.");

            RuleFor(x => x.Especialidad)
                .NotEmpty().WithMessage("La especialidad es obligatoria.")
                .MinimumLength(3).WithMessage("La especialidad debe tener al menos 3 caracteres.")
                .MaximumLength(60).WithMessage("La especialidad no puede exceder los 60 caracteres.");
        }
    }
}
