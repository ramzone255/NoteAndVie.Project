using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Status.Queries.GetProduct_StatusList
{
    public class GetProduct_StatusListQuery : IRequest<Product_StatusListVm>
    {
        public int id_product_status {  get; set; }
    }
}
