using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Domain.Entities
{
    public class Employees
    {
        [Key]
        public int id_employees { get; set; }
        public string employees_name { get; set; }
        public string login {  get; set; }
        public string password { get; set; }
        [ForeignKey("Post")]
        public int id_post { get; set; }
        public Post Post { get; set; }
    }
}
