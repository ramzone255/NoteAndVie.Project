using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Status.Queries.GetProduct_StatusDetails
{
    public class GetProduct_StatusDetailsQueryValidator : AbstractValidator<GetProduct_StatusDetailsQuery>
    {
        public GetProduct_StatusDetailsQueryValidator()
        {
            RuleFor(note => note.id_product_status).NotEmpty();
        }
    }
}
