using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Domain.Entities
{
    public class Client
    {
        [Key]
        public int id_client {  get; set; }
        public string client_name { get; set; }
        public string client_mail {  get; set; }
        [ForeignKey("Client_Type")]
        public int id_client_type { get; set; }
        public Client_Type Client_Type { get; set; }
        
    }
}
