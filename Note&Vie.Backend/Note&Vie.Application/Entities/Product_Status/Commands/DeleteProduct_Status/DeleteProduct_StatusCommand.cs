using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Status.Commands.DeleteProduct_Status
{
    public class DeleteProduct_StatusCommand : IRequest
    {
        public int id_product_status { get; set; }
    }
}
