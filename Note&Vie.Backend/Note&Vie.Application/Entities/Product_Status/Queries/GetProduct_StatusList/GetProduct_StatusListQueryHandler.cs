using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Note_Vie.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Status.Queries.GetProduct_StatusList
{
    public class GetProduct_StatusListQueryHandler : IRequestHandler<GetProduct_StatusListQuery, Product_StatusListVm>
    {
        private readonly INote_VieDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetProduct_StatusListQueryHandler(INote_VieDbContext dbContext,
            IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<Product_StatusListVm> Handle(GetProduct_StatusListQuery request,
            CancellationToken cancellationToken)
        {
            var notesQuery = await _dbContext.Product_Status
                .Where(note => note.id_product_status == request.id_product_status)
                .ProjectTo<Product_StatusLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new Product_StatusListVm { Product_Status = notesQuery };
        }
    }
}
