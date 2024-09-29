using MediatR;
using Note_Vie.Application.Common.Exceptions;
using Note_Vie.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Status.Commands.DeleteProduct_Status
{
    public class DeleteProduct_StatusCommandHandler 
        : IRequestHandler<DeleteProduct_StatusCommand>
    {
        private readonly INote_VieDbContext _dbContext;

        public DeleteProduct_StatusCommandHandler(INote_VieDbContext dbContext) =>
            _dbContext = dbContext;

        public async Task Handle(DeleteProduct_StatusCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Product_Status
                .FindAsync(new object[] { request.id_product_status }, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Product_Status), request.id_product_status);
            }

            _dbContext.Product_Status.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return;
        }
    }
}
