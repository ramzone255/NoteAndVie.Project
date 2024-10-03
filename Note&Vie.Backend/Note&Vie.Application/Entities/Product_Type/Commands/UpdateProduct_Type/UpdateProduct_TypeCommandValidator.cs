using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Type.Commands.UpdateProduct_Type
{
    public class UpdateProduct_TypeCommandValidator : AbstractValidator<UpdateProduct_TypeCommand>
    {
        public UpdateProduct_TypeCommandValidator()
        {
            RuleFor(updateNoteCommand => updateNoteCommand.id_product_type).NotEmpty();
            RuleFor(updateNoteCommand => updateNoteCommand.product_type_name).NotEmpty().MaximumLength(50);
        }
    }
}
