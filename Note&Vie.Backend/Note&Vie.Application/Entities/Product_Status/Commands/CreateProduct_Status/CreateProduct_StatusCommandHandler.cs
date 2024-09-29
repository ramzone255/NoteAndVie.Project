using MediatR;
using Note_Vie.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Note_Vie.Domain.Entities;

namespace Note_Vie.Application.Entities.Product_Status.Commands.CreateProduct_Status
{
    public class CreateProduct_StatusCommandHandler
    : IRequestHandler<CreateProduct_StatusCommand, int>
    // If you use Guid to indicate the entity ID, specify the Guid instead of int
    // Если вы успользуете Guid для обозначения ID сущности, укажите Guid вместо int
    {
        private readonly INote_VieDbContext _dbContext;
        public CreateProduct_StatusCommandHandler(INote_VieDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<int> Handle(CreateProduct_StatusCommand request, CancellationToken cancellationToken)
        {
            var product_status = new Domain.Entities.Product_Status
            {
                product_status_name = request.product_status_name
            };

            await _dbContext.Product_Status.AddAsync(product_status, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return product_status.id_product_status;
        }
    }
}
