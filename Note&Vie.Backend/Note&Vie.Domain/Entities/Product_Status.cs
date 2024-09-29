using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Domain.Entities
{
    public class Product_Status
    {
        [Key]
        public int id_product_status {  get; set; }
        public string product_status_name { get; set; }
        public ICollection<Product> Product {  get; set; }

    }
}
