using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Domain.Entities
{
    public class Product
    {
        public int id_product { get; set; }
        public string product_name { get; set; }
        public string product_description { get; set; }
        public double product_price { get; set; }
        public string? product_image { get; set; }
        public Product_Status Product_Status { get; set; }
        public Product_Type Product_Type { get; set; }
    }
}
