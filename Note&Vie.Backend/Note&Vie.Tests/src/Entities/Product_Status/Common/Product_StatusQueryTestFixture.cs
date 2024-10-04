using AutoMapper;
using Note_Vie.Application.Common.Mapping;
using Note_Vie.Application.Interfaces;
using Note_Vie.Persistence.Data;
using Note_Vie.Tests.src.Entities.Product_Type.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Tests.src.Entities.Product_Status.Common
{
    public class Product_StatusQueryTestFixture : IDisposable
    {
        public Note_VieDbContext Context;
        public IMapper Mapper;

        public Product_StatusQueryTestFixture()
        {
            Context = Product_StatusContextFactory.Create();
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
            Product_StatusContextFactory.Destroy(Context);
        }
    }

    [CollectionDefinition("Product_StatusQueryCollection")]
    public class QueryCollection : ICollectionFixture<Product_StatusQueryTestFixture> { }
}
