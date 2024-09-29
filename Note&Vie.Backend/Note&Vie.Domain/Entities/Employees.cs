using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Domain.Entities
{
    public class Employees
    {
        public int id_employees { get; set; }
        public string employees_name { get; set; }
        public string login {  get; set; }
        public string password { get; set; }
        public Post Post { get; set; }
    }
}
