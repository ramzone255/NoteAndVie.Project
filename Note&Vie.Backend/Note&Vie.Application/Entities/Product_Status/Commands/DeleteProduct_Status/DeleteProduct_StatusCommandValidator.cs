using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Status.Commands.DeleteProduct_Status
{
    public class DeleteProduct_StatusCommandValidator : AbstractValidator<DeleteProduct_StatusCommand>
    {
        public DeleteProduct_StatusCommandValidator()
        {
            RuleFor(deleteNoteCommand => deleteNoteCommand.id_product_status).NotEmpty();
        }
    }
}
