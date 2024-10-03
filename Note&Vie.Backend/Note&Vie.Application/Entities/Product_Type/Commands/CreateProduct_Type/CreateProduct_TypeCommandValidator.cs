using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Type.Commands.CreateProduct_Type
{
    public class CreateProduct_TypeCommandValidator : AbstractValidator<CreateProduct_TypeCommand>
    {
        public CreateProduct_TypeCommandValidator()
        {
            RuleFor(createNoteCommand => 
            createNoteCommand.product_type_name).NotEmpty().MaximumLength(50);
        }
    }
}
