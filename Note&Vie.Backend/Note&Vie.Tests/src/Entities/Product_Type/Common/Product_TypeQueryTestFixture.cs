using AutoMapper;
using Note_Vie.Application.Common.Mapping;
using Note_Vie.Application.Interfaces;
using Note_Vie.Persistence.Data;
using Note_Vie.Tests.src.Entities.Product_Status.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Tests.src.Entities.Product_Type.Common
{
    public class Product_TypeQueryTestFixture : IDisposable
    {
        public Note_VieDbContext Context;
        public IMapper Mapper;

        public Product_TypeQueryTestFixture()
        {
            Context = Product_TypeContextFactory.Create();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AllowNullCollections = true;
                cfg.ShouldMapMethod = (m => false);
                cfg.AddProfile(new AssemblyMappingProfile(
                    typeof(INote_VieDbContext).Assembly));
            });
            Mapper = configurationProvider.CreateMapper();
        }

        public void Dispose()
        {
            Product_TypeContextFactory.Destroy(Context);
        }
    }

    [CollectionDefinition("Product_TypeQueryCollection")]
    public class QueryCollection : ICollectionFixture<Product_TypeQueryTestFixture> { }
}
