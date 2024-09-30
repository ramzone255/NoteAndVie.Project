using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Status.Queries.GetProduct_StatusList
{
    public class Product_StatusListVm
    {
        public IList<Product_StatusLookupDto> Product_Status {  get; set; }
    }
}
