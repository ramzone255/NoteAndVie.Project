using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Type.Commands.DeleteProduct_Type
{
    public class DeleteProduct_TypeCommand : IRequest
    {
        public int id_product_type { get; set; }
    }
}
