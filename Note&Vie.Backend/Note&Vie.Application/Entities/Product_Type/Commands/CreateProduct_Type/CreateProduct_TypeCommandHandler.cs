using MediatR;
using Note_Vie.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Type.Commands.CreateProduct_Type
{
    public class CreateProduct_TypeCommandHandler 
    : IRequestHandler<CreateProduct_TypeCommand, int>
    {
        private readonly INote_VieDbContext _dbContext;

        public CreateProduct_TypeCommandHandler(INote_VieDbContext dbContext) =>
            _dbContext = dbContext;

        public async Task<int> Handle(CreateProduct_TypeCommand request, CancellationToken cancellationToken)
        {
            var product_type = new Domain.Entities.Product_Type
            {
                product_type_name = request.product_type_name
            };

            await _dbContext.Product_Type.AddAsync(product_type, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return product_type.id_product_type;
        }
    }
}
