using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Type.Queries.GetProduct_TypeDetails
{
    public class GetProduct_TypeDetailsQueryValidator : AbstractValidator<GetProduct_TypeDetailsQuery>
    {
        public GetProduct_TypeDetailsQueryValidator()
        {
            RuleFor(note => note.id_product_type).NotEmpty();
        }
    }
}
