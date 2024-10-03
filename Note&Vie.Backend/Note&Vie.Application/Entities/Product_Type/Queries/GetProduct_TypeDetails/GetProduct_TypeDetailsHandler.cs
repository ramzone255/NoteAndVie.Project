using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Note_Vie.Application.Common.Exceptions;
using Note_Vie.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Type.Queries.GetProduct_TypeDetails
{
    public class GetProduct_TypeDetailsHandler
        : IRequestHandler<GetProduct_TypeDetailsQuery, Product_TypeDetailsVm>
    {
        private readonly INote_VieDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetProduct_TypeDetailsHandler(INote_VieDbContext dbContext, 
            IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<Product_TypeDetailsVm> Handle(GetProduct_TypeDetailsQuery request,
            CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Product_Type
                .FirstOrDefaultAsync(note =>
                note.id_product_type == request.id_product_type, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Domain.Entities.Product_Type), request.id_product_type);
            }

            return _mapper.Map<Product_TypeDetailsVm>(entity);
        }
    }
}
