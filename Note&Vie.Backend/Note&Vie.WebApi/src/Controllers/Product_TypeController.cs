using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Note_Vie.Application.Entities.Product_Type.Commands.CreateProduct_Type;
using Note_Vie.Application.Entities.Product_Type.Commands.DeleteProduct_Type;
using Note_Vie.Application.Entities.Product_Type.Commands.UpdateProduct_Type;
using Note_Vie.Application.Entities.Product_Type.Queries.GetProduct_TypeDetails;
using Note_Vie.Application.Entities.Product_Type.Queries.GetProduct_TypeList;
using Note_Vie.WebApi.src.EntitiesDto.Product_TypeDto;

namespace Note_Vie.WebApi.src.Controllers
{
    [Route("api/[controller]")]
    public class Product_TypeController : BaseController
    {
        private readonly IMapper _mapper;
        public Product_TypeController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<Product_TypeListVm>> GetAll()
        {
            var query = new GetProduct_TypeListQuery
            {

            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{id_product_type}")]
        public async Task<ActionResult<Product_TypeDetailsVm>> Get(int id_product_type)
        {
            var query = new GetProduct_TypeDetailsQuery
            {
                id_product_type = id_product_type
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateProduct_TypeDto createProduct_TypeDto)
        {
            var command = _mapper.Map<CreateProduct_TypeCommand>(createProduct_TypeDto);
            var id_product_type = await Mediator.Send(command);
            return Ok(id_product_type);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateProduct_TypeDto updateProduct_TypeDto)
        {
            var command = _mapper.Map<UpdateProduct_TypeCommand>(updateProduct_TypeDto);
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id_product_type}")]
        public async Task<IActionResult> Delete(int id_product_type)
        {
            var command = new DeleteProduct_TypeCommand
            {
                id_product_type = id_product_type
            };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
