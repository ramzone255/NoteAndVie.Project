using Note_Vie.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Tests.src.Entities.Product_Status.Common
{
    public abstract class TestCommandBase : IDisposable
    {
        protected readonly Note_VieDbContext Context;

        public TestCommandBase()
        {
            Context = Product_StatusContextFactory.Create();
        }

        public void Dispose()
        {
            Product_StatusContextFactory.Destroy(Context);
        }
    }
}
