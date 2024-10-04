using Note_Vie.Persistence.Data;
using Note_Vie.Tests.src.Entities.Product_Type.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Tests.src.Entities.Product_Status.Common
{
    public abstract class Product_StatusTestCommandBase : IDisposable
    {
        protected readonly Note_VieDbContext Context;

        public Product_StatusTestCommandBase()
        {
            Context = Product_StatusContextFactory.Create();
        }

        public void Dispose()
        {
            Product_StatusContextFactory.Destroy(Context);
        }
    }
}
