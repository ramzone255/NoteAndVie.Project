using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Persistence.Data
{
    public class DbInitializer
    {
        public static void Initialize(Note_VieDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
