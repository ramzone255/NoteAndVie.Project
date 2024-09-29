using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Domain.Entities
{
    public class Client
    {
        public int id_client {  get; set; }
        public string client_name { get; set; }
        public string client_mail {  get; set; }
        public Client_Type Client_Type { get; set; }
    }
}
