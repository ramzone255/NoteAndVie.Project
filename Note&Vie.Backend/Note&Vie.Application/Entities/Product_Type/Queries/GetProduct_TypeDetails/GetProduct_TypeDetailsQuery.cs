using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Type.Queries.GetProduct_TypeDetails
{
    public class GetProduct_TypeDetailsQuery : IRequest<Product_TypeDetailsVm>
    {
        public int id_product_type {  get; set; }
    }
}
