using Microsoft.EntityFrameworkCore;
using Note_Vie.Application.Entities.Product_Status.Commands.CreateProduct_Status;
using Note_Vie.Application.Entities.Product_Type.Commands.CreateProduct_Type;
using Note_Vie.Tests.src.Entities.Product_Type.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Tests.src.Entities.Product_Type.Commands
{
    public class CreateProduct_TypeCommandHandlerTests : Product_TypeTestCommandBase
    {
        [Fact]
        public async Task CreateProduct_TypeCommandHandler_Success()
        {
            var handler = new CreateProduct_TypeCommandHandler(Context);
            var product_type_name = "product type name";

            var id_product_type = await handler.Handle(
                new CreateProduct_TypeCommand
                {
                    product_type_name = product_type_name
                },
                CancellationToken.None);

            Assert.NotNull(
               await Context.Product_Type.SingleOrDefaultAsync(note =>
               note.id_product_type == id_product_type &&
               note.product_type_name == product_type_name));
        }
    }
}
