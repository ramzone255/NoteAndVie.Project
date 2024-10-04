using Microsoft.EntityFrameworkCore;
using Note_Vie.Application.Common.Exceptions;
using Note_Vie.Application.Entities.Product_Status.Commands.UpdateProduct_Status;
using Note_Vie.Application.Entities.Product_Type.Commands.UpdateProduct_Type;
using Note_Vie.Tests.src.Entities.Product_Status.Common;
using Note_Vie.Tests.src.Entities.Product_Type.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Tests.src.Entities.Product_Type.Commands
{
    public class UpdateProduct_TypeCommandHandlerTests : Product_TypeTestCommandBase
    {
        [Fact]
        public async Task UpdateProduct_TypeCommandHandler_Success()
        {
            var handler = new UpdateProduct_TypeCommandHandler(Context);
            var updatedName = "new product name";

            await handler.Handle(new UpdateProduct_TypeCommand
            {
                id_product_type = Product_TypeContextFactory.id_product_type_for_update,
                product_type_name = updatedName
            }, CancellationToken.None);

            Assert.NotNull(await Context.Product_Type.SingleOrDefaultAsync(note =>
            note.id_product_type == Product_TypeContextFactory.id_product_type_for_update &&
            note.product_type_name == updatedName));
        }

        [Fact]
        public async Task UpdateProduct_TypeCommandhandler_FailOnWrongId()
        {
            var handler = new UpdateProduct_TypeCommandHandler(Context);

            await Assert.ThrowsAsync<NotFoundException>(async () =>
            await handler.Handle(
                new UpdateProduct_TypeCommand
                {
                    id_product_type = 5
                },
                CancellationToken.None));
        }
    }
}
