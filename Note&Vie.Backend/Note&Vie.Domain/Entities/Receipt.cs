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
        public Client Client { get; set; }
        public int id_client { get; set; }
        [ForeignKey("Employees")]
        public Employees Employees { get; set; }
        public int id_employees { get; set; }
        [ForeignKey("Product")]
        public Product Product { get; set; }
        public int id_product { get; set; }
    }
}
