using AutoMapper;
using Note_Vie.Application.Entities.Product_Status.Queries.GetProduct_StatusDetails;
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
    public class GetProduct_StatusDetailsHandlerTests
    {
        private readonly Note_VieDbContext Context;
        private readonly IMapper Mapper;

        public GetProduct_StatusDetailsHandlerTests(QueryTestFixture fixture)
        {
            Context = fixture.Context;
            Mapper = fixture.Mapper;
        }

        [Fact]
        public async Task GetProduct_StatusDetailsQueryHandler_Success()
        {
            var handler = new GetProduct_StatusDetailsHandler(Context, Mapper);

            var result = await handler.Handle(
                new GetProduct_StatusDetailsQuery
                {
                    id_product_status = 1
                },
                CancellationToken.None);

            result.ShouldBeOfType<Product_StatusDetailsVm>();
            result.product_status_name.ShouldBe("Name1");
        }
    }
}
