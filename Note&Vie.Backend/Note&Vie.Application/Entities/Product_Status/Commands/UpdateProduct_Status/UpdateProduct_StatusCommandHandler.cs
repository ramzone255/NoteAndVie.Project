using MediatR;
using Microsoft.EntityFrameworkCore;
using Note_Vie.Application.Interfaces;
using Note_Vie.Application.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Status.Commands.UpdateProduct_Status
{
    public class UpdateProduct_StatusCommandHandler : 
        IRequestHandler<UpdateProduct_StatusCommand>
    {
        private readonly INote_VieDbContext _dbContext;

        public UpdateProduct_StatusCommandHandler(INote_VieDbContext dbContext) =>
            _dbContext = dbContext;

        public async Task Handle(UpdateProduct_StatusCommand request, CancellationToken cancellationToken)
        {
            var entity =
                await _dbContext.Product_Status.FirstOrDefaultAsync(note =>
                    note.id_product_status == request.id_product_status, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Product_Status), request.id_product_status);
            }

            entity.product_status_name = request.product_status_name;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return;
        }
    }
}
