using Microsoft.EntityFrameworkCore;
using Note_Vie.Application.Common.Exceptions;
using Note_Vie.Application.Entities.Product_Status.Commands.UpdateProduct_Status;
using Note_Vie.Tests.src.Entities.Product_Status.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Tests.src.Entities.Product_Status.Commands
{
    public class UpdateProduct_StatusCommandHandlerTests : TestCommandBase
    {
        [Fact]
        public async Task UpdateProduct_StatusCommandHandler_Success()
        {
            var handler = new UpdateProduct_StatusCommandHandler(Context);
            var updatedName = "new product name";

            await handler.Handle(new UpdateProduct_StatusCommand
            {
                id_product_status = Product_StatusContextFactory.id_product_status_for_update,
                product_status_name = updatedName
            }, CancellationToken.None);

            Assert.NotNull(await Context.Product_Status.SingleOrDefaultAsync(note =>
            note.id_product_status == Product_StatusContextFactory.id_product_status_for_update &&
            note.product_status_name == updatedName));
        }

        [Fact]
        public async Task UpdateProduct_StatusCommandhandler_FailOnWrongId()
        {
            var handler = new UpdateProduct_StatusCommandHandler(Context);

            await Assert.ThrowsAsync<NotFoundException>(async () =>
            await handler.Handle(
                new UpdateProduct_StatusCommand
                {
                    id_product_status = 5
                },
                CancellationToken.None));
        }
    }
}
