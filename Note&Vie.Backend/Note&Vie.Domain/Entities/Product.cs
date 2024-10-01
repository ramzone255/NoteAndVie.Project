using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Domain.Entities
{
    public class Product
    {
        [Key]
        public int id_product { get; set; }
        public string product_name { get; set; }
        public string product_description { get; set; }
        public double product_price { get; set; }
        public string? product_image { get; set; }
        [ForeignKey("Product_Status")]
        public int id_product_status { get; set; }
        public Product_Status Product_Status { get; set; }
        [ForeignKey("Product_Type")]
        public int id_product_type { get; set; }
        public Product_Type Product_Type { get; set; }
    }
}
