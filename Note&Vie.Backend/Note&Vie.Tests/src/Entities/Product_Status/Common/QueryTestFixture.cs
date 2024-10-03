using AutoMapper;
using Note_Vie.Application.Common.Mapping;
using Note_Vie.Application.Interfaces;
using Note_Vie.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Tests.src.Entities.Product_Status.Common
{
    public class QueryTestFixture : IDisposable
    {
        public Note_VieDbContext Context;
        public IMapper Mapper;

        public QueryTestFixture()
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

    [CollectionDefinition("QueryCollection")]
    public class QueryCollection : ICollectionFixture<QueryTestFixture> { }
}
