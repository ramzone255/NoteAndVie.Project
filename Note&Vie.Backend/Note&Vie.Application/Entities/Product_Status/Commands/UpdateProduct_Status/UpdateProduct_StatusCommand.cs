using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Status.Commands.UpdateProduct_Status
{
    public class UpdateProduct_StatusCommand : IRequest
    {
        public int id_product_status {  get; set; }
        public string product_status_name { get; set; }
    }
}
