using AutoMapper;
using Note_Vie.Application.Entities.Product_Status.Queries.GetProduct_StatusList;
using Note_Vie.Application.Entities.Product_Type.Queries.GetProduct_TypeList;
using Note_Vie.Persistence.Data;
using Note_Vie.Tests.src.Entities.Product_Status.Common;
using Note_Vie.Tests.src.Entities.Product_Type.Common;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Tests.src.Entities.Product_Type.Queries
{
    [Collection("Product_TypeQueryCollection")]
    public class GetProduct_TypeListQuetyHandlerTests
    {
        private readonly Note_VieDbContext Context;
        private readonly IMapper Mapper;

        public GetProduct_TypeListQuetyHandlerTests(Product_TypeQueryTestFixture fixture)
        {
            Context = fixture.Context;
            Mapper = fixture.Mapper;
        }

        [Fact]
        public async Task GetProduct_TypeListQueryHandler_Success()
        {
            var handler = new GetProduct_TypeListQueryHandler(Context, Mapper);

            var result = await handler.Handle(
                new GetProduct_TypeListQuery
                {
                    id_product_type = 0
                },
                CancellationToken.None);

            result.ShouldBeOfType<Product_TypeListVm>();
            result.Product_Type.Count.ShouldBe(4);
        }
    }
}
