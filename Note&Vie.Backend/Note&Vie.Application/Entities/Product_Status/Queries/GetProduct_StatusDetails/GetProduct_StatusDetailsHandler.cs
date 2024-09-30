using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Note_Vie.Application.Common.Exceptions;
using Note_Vie.Application.Interfaces;
using Note_Vie.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Status.Queries.GetProduct_StatusDetails
{
    public class GetProduct_StatusDetailsHandler
        : IRequestHandler<GetProduct_StatusDetailsQuery, Product_StatusDetailsVm>
    {
        private readonly INote_VieDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetProduct_StatusDetailsHandler(INote_VieDbContext dbContext,
            IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);
        public async Task<Product_StatusDetailsVm> Handle(GetProduct_StatusDetailsQuery request,
            CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Product_Status
                .FirstOrDefaultAsync(note =>
                note.id_product_status == request.id_product_status, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Domain.Entities.Product_Status), request.id_product_status);
            }

            return _mapper.Map<Product_StatusDetailsVm>(entity);
        }
    }
}
