using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Note_Vie.Application.Common.Exceptions;
using Note_Vie.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Type.Commands.UpdateProduct_Type
{
    public class UpdateProduct_TypeCommandHandler 
        : IRequestHandler<UpdateProduct_TypeCommand>
    {
        private readonly INote_VieDbContext _dbContext;

        public UpdateProduct_TypeCommandHandler(INote_VieDbContext dbContext) =>
            _dbContext = dbContext;

        public async Task Handle(UpdateProduct_TypeCommand request, CancellationToken cancellationToken)
        {
            var entity =
                await _dbContext.Product_Type.FirstOrDefaultAsync(note =>
                note.id_product_type == request.id_product_type, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Product_Type), request.id_product_type);
            }
            
            entity.product_type_name = request.product_type_name;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return;
        }
    }
}
