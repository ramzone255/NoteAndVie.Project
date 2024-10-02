using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Status.Commands.CreateProduct_Status
{
    public class CreateProduct_StatusCommandValidator : AbstractValidator<CreateProduct_StatusCommand>
    {
        public CreateProduct_StatusCommandValidator()
        {
            RuleFor(createNoteCommand =>
            createNoteCommand.product_status_name).NotEmpty().MaximumLength(50);
        }
    }
}
