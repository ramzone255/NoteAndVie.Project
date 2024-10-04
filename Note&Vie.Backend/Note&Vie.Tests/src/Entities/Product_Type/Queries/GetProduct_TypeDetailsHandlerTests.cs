using AutoMapper;
using Note_Vie.Application.Entities.Product_Status.Queries.GetProduct_StatusDetails;
using Note_Vie.Application.Entities.Product_Type.Queries.GetProduct_TypeDetails;
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
    public class GetProduct_TypeDetailsHandlerTests
    {
        private readonly Note_VieDbContext Context;
        private readonly IMapper Mapper;

        public GetProduct_TypeDetailsHandlerTests(Product_TypeQueryTestFixture fixture)
        {
            Context = fixture.Context;
            Mapper = fixture.Mapper;
        }

        [Fact]
        public async Task GetProduct_TypeDetailsQueryHandler_Success()
        {
            var handler = new GetProduct_TypeDetailsHandler(Context, Mapper);

            var result = await handler.Handle(
                new GetProduct_TypeDetailsQuery
                {
                    id_product_type = 1
                },
                CancellationToken.None);

            result.ShouldBeOfType<Product_TypeDetailsVm>();
            result.product_type_name.ShouldBe("Name1");
        }
    }
}
