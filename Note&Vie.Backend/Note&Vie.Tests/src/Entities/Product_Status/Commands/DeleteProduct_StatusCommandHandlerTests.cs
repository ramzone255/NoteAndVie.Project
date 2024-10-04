using Note_Vie.Application.Common.Exceptions;
using Note_Vie.Application.Entities.Product_Status.Commands.CreateProduct_Status;
using Note_Vie.Application.Entities.Product_Status.Commands.DeleteProduct_Status;
using Note_Vie.Tests.src.Entities.Product_Status.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Tests.src.Entities.Product_Status.Commands
{
    public class DeleteProduct_StatusCommandHandlerTests : Product_StatusTestCommandBase
    {
        [Fact]
        public async Task DeleteProduct_StatusCommandHandler_Success()
        {
            var handler = new DeleteProduct_StatusCommandHandler(Context);

            await handler.Handle(new DeleteProduct_StatusCommand
            {
                id_product_status = Product_StatusContextFactory.id_product_status_for_delete,

            }, CancellationToken.None);

            Assert.Null(Context.Product_Status.SingleOrDefault(note =>
            note.id_product_status == Product_StatusContextFactory.id_product_status_for_delete));
        }

        [Fact]
        public async Task DeleteNoteCommandHandler_FailOnWrongId()
        {
            var handler = new DeleteProduct_StatusCommandHandler(Context);

            await Assert.ThrowsAsync<NotFoundException>(async () =>
            await handler.Handle(
                new DeleteProduct_StatusCommand
                {
                    id_product_status = 5
                },
                CancellationToken.None));
        }
    }
}
