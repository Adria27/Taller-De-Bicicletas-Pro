using FluentValidation;
using TallerDeBicicletasPro.Application.DTOs;

namespace TallerDeBicicletasPro.Application.Validators
{
    public class ClienteValidator : AbstractValidator<ClienteDto>
    {
        public ClienteValidator()
        {
            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage("El nombre es obligatorio.")
                .MinimumLength(3).WithMessage("Mínimo 3 caracteres.");

            RuleFor(x => x.Telefono)
                .NotEmpty().WithMessage("El teléfono es obligatorio.");

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Debe ser un email válido.");
        }
    }
}
