using Note_Vie.Persistence.Data;
using Note_Vie.Tests.src.Entities.Product_Status.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Tests.src.Entities.Product_Type.Common
{
    public abstract class Product_TypeTestCommandBase : IDisposable
    {
        protected readonly Note_VieDbContext Context;

        public Product_TypeTestCommandBase()
        {
            Context = Product_TypeContextFactory.Create();
        }

        public void Dispose()
        {
            Product_TypeContextFactory.Destroy(Context);
        }
    }
}
