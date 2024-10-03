using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Note_Vie.Application.Entities.Product_Status.Commands.CreateProduct_Status;
using Note_Vie.Application.Entities.Product_Status.Commands.DeleteProduct_Status;
using Note_Vie.Application.Entities.Product_Status.Commands.UpdateProduct_Status;
using Note_Vie.Application.Entities.Product_Status.Queries.GetProduct_StatusDetails;
using Note_Vie.Application.Entities.Product_Status.Queries.GetProduct_StatusList;
using Note_Vie.WebApi.src.EntitiesDto.Product_StatusDto;

namespace Note_Vie.WebApi.src.Controllers
{
    [Route("api/[controller]")]
    public class Product_StatusController : BaseController
    {
        private readonly IMapper _mapper;

        public Product_StatusController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<Product_StatusListVm>> GetAll()
        {
            var query = new GetProduct_StatusListQuery
            {
                 
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{id_product_status}")]
        public async Task<ActionResult<Product_StatusDetailsVm>> Get(int id_product_status)
        {
            var query = new GetProduct_StatusDetailsQuery
            {
                id_product_status = id_product_status
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateProduct_StatusDto createProduct_StatusDto)
        {
            var command = _mapper.Map<CreateProduct_StatusCommand>(createProduct_StatusDto);
            var id_product_status = await Mediator.Send(command);
            return Ok(id_product_status);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateProduct_StatusDto updateProduct_StatusDto)
        {
            var command = _mapper.Map<UpdateProduct_StatusCommand>(updateProduct_StatusDto);
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id_product_status}")]
        public async Task<IActionResult> Delete(int id_product_status)
        {
            var command = new DeleteProduct_StatusCommand
            {
                id_product_status = id_product_status
            };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
