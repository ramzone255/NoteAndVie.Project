using Microsoft.EntityFrameworkCore;
using Note_Vie.Application.Entities.Product_Status.Commands.CreateProduct_Status;
using Note_Vie.Tests.src.Entities.Product_Status.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Tests.src.Entities.Product_Status.Commands
{
    public class CreateProduct_StatusCommandHandlerTests : Product_StatusTestCommandBase
    {
        [Fact]
        public async Task CreateProduct_StatusCommandHandler_Success()
        {
            var handler = new CreateProduct_StatusCommandHandler(Context);
            var product_status_name = "product status name";

            var id_product_status = await handler.Handle(
                new CreateProduct_StatusCommand
                {
                    product_status_name = product_status_name
                },
                CancellationToken.None);

            Assert.NotNull(
               await Context.Product_Status.SingleOrDefaultAsync(note =>
               note.id_product_status == id_product_status && 
               note.product_status_name == product_status_name));
        }
    }
}
