using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Note_Vie.WebApi.src.Controllers
{
    [ApiController]
    [Route("ali/[controller]/[action]")]
    public abstract class BaseController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator =>
            _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
