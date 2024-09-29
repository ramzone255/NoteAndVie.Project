using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Domain.Entities
{
    public class Receipt
    {
        public int id_receipt {  get; set; }
        public Client Client { get; set; }
        public Employees Employees { get; set; }
        public Product Product { get; set; }
    }
}
