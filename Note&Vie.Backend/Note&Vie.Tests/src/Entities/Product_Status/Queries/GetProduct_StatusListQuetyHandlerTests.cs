using AutoMapper;
using Note_Vie.Application.Entities.Product_Status.Queries.GetProduct_StatusList;
using Note_Vie.Persistence.Data;
using Note_Vie.Tests.src.Entities.Product_Status.Common;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Tests.src.Entities.Product_Status.Queries
{
    [Collection("QueryCollection")]
    public class GetProduct_StatusListQuetyHandlerTests
    {
        private readonly Note_VieDbContext Context;
        private readonly IMapper Mapper;

        public GetProduct_StatusListQuetyHandlerTests(QueryTestFixture fixture)
        {
            Context = fixture.Context;
            Mapper = fixture.Mapper;
        }

        [Fact]
        public async Task GetProduct_StatusListQueryHandler_Success()
        {
            var handler = new GetProduct_StatusListQueryHandler(Context, Mapper);

            var result = await handler.Handle(
                new GetProduct_StatusListQuery
                {
                    id_product_status = 0
                },
                CancellationToken.None);

            result.ShouldBeOfType<Product_StatusListVm>();
            result.Product_Status.Count.ShouldBe(4);
        }
    }
}
