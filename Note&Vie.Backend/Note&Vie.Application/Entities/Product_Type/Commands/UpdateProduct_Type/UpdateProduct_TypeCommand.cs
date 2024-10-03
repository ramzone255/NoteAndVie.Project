using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Type.Commands.UpdateProduct_Type
{
    public class UpdateProduct_TypeCommand : IRequest
    {
        public int id_product_type {  get; set; }
        public string product_type_name { get; set; }
    }
}
