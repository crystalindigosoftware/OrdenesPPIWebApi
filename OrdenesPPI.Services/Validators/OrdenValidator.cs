using OrdenesPPI.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Services.Validators
{
    public class OrdenValidator : AbstractValidator<Orden>
    {
        public OrdenValidator()
        {

            RuleFor(x => x.Cantidad)
                    .GreaterThan(0)
                    .NotEmpty()
                    .WithMessage("Cantidad debe ser mayor a 0");

            RuleFor(x => x.Operacion)
                .Must(value => value == "C" || value == "V")
                .NotEmpty();

            RuleFor(x => x.ActivoId)
                .GreaterThan(0)
                .NotEmpty();
                
        }
    }
}
