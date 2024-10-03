using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Type.Commands.CreateProduct_Type
{
    public class CreateProduct_TypeCommand : IRequest<int>
    {
        public string product_type_name { get; set; }
    }
}
