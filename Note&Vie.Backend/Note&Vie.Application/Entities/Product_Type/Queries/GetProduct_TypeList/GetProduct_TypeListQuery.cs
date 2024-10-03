using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Type.Queries.GetProduct_TypeList
{
    public class GetProduct_TypeListQuery : IRequest<Product_TypeListVm>
    {
        public int id_product_type {  get; set; }
    }
}
