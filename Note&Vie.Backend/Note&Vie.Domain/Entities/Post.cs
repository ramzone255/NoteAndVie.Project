using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Domain.Entities
{
    public class Post
    {
        [Key]
        public int id_post { get; set; }
        public string post_name { get; set; }
        public ICollection<Employees> Employees { get; set; }
    }
}
