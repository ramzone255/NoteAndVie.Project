using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Domain.Entities
{
    public class Product_Type
    {
        [Key]
        public int id_product_type { get; set; }
        public string product_type_name { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
