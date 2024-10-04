using Note_Vie.Application.Common.Exceptions;
using Note_Vie.Application.Entities.Product_Status.Commands.DeleteProduct_Status;
using Note_Vie.Application.Entities.Product_Type.Commands.DeleteProduct_Type;
using Note_Vie.Tests.src.Entities.Product_Status.Common;
using Note_Vie.Tests.src.Entities.Product_Type.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Tests.src.Entities.Product_Type.Commands
{
    public class DeleteProduct_TypeCommandHandlerTests : Product_TypeTestCommandBase
    {
        [Fact]
        public async Task DeleteProduct_TypeCommandHandler_Success()
        {
            var handler = new DeleteProduct_TypeCommandHandler(Context);

            await handler.Handle(new DeleteProduct_TypeCommand
            {
                id_product_type = Product_TypeContextFactory.id_product_type_for_delete,

            }, CancellationToken.None);

            Assert.Null(Context.Product_Type.SingleOrDefault(note =>
            note.id_product_type == Product_TypeContextFactory.id_product_type_for_delete));
        }

        [Fact]
        public async Task DeleteNoteCommandHandler_FailOnWrongId()
        {
            var handler = new DeleteProduct_TypeCommandHandler(Context);

            await Assert.ThrowsAsync<NotFoundException>(async () =>
            await handler.Handle(
                new DeleteProduct_TypeCommand
                {
                    id_product_type = 5
                },
                CancellationToken.None));
        }
    }
}
