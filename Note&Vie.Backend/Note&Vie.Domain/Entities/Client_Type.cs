using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Domain.Entities
{
    public class Client_Type
    {
        [Key]
        public int id_client_type { get; set;}
        public double discount { get; set;}
        public string client_type_name { get; set;}
        public ICollection<Client> Client {  get; set;}
    }
}
