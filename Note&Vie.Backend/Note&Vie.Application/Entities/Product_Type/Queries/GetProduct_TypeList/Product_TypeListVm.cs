using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Type.Queries.GetProduct_TypeList
{
    public class Product_TypeListVm
    {
        public IList<Product_TypeLookupDto> Product_Type {  get; set; }
    }
}
