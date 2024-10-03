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

namespace Note_Vie.Application.Entities.Product_Type.Queries.GetProduct_TypeList
{
    public class GetProduct_TypeListQueryHandler : IRequestHandler<GetProduct_TypeListQuery, Product_TypeListVm>
    {
        private readonly INote_VieDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetProduct_TypeListQueryHandler(INote_VieDbContext dbContext,
            IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<Product_TypeListVm> Handle(GetProduct_TypeListQuery request,
            CancellationToken cancellationToken)
        {
            var notesQuery = await _dbContext.Product_Type
                .Where(note => note.id_product_type == request.id_product_type)
                .ProjectTo<Product_TypeLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new Product_TypeListVm { Product_Type = notesQuery };
        }
    }
}
