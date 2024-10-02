using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Status.Commands.UpdateProduct_Status
{
    public class UpdateProduct_StatusCommandValidator : AbstractValidator<UpdateProduct_StatusCommand>
    {
        public UpdateProduct_StatusCommandValidator()
        {
            RuleFor(updateNoteCommand => updateNoteCommand.id_product_status).NotEmpty();
            RuleFor(updateNoteCommand => updateNoteCommand.product_status_name).NotEmpty().MaximumLength(50);
        }
    }
}
