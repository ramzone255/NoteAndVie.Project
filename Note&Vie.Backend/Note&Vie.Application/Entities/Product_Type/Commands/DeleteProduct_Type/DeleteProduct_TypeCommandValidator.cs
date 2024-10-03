using FluentValidation;
using Note_Vie.Application.Entities.Product_Status.Commands.DeleteProduct_Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Type.Commands.DeleteProduct_Type
{
    public class DeleteProduct_TypeCommandValidator : AbstractValidator<DeleteProduct_TypeCommand>
    {
        public DeleteProduct_TypeCommandValidator()
        {
            RuleFor(deleteNoteCommand => deleteNoteCommand.id_product_type).NotEmpty();
        }
    }
}
