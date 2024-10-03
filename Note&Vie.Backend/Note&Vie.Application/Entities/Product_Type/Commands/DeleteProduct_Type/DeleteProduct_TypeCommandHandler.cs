using MediatR;
using Note_Vie.Application.Common.Exceptions;
using Note_Vie.Application.Entities.Product_Status.Queries.GetProduct_StatusDetails;
using Note_Vie.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Type.Commands.DeleteProduct_Type
{
    public class DeleteProduct_TypeCommandHandler
        : IRequestHandler<DeleteProduct_TypeCommand>
    {
        private readonly INote_VieDbContext _dbContext;

        public DeleteProduct_TypeCommandHandler(INote_VieDbContext dbContext) =>
            _dbContext = dbContext;

        public async Task Handle(DeleteProduct_TypeCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Product_Type
                .FindAsync(new object[] { request.id_product_type }, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Product_Type), request.id_product_type);
            }

            _dbContext.Product_Type.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return;
        }
    }
}
