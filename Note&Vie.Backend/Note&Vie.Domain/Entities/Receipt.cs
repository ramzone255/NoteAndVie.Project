using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Domain.Entities
{
    public class Receipt
    {
        [Key]
        public int id_receipt {  get; set; }
        [ForeignKey("Client")]
        public int id_client { get; set; }
        public Client Client { get; set; }
        [ForeignKey("Employees")]
        public int id_employees { get; set; }
        public Employees Employees { get; set; }
        [ForeignKey("Product")]
        public int id_product { get; set; }
        public Product Product { get; set; }
    }
}
