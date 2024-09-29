using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Status.Commands.CreateProduct_Status
{
    public class CreateProduct_StatusCommand : IRequest<int>
    {
        public string product_status_name {  get; set; }
    }
}
