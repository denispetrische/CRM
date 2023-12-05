using Asp.Versioning;
using CRM.API.Requests.v1.UserController;
using CRM.API.Responses.v1.UserController;
using CRM.Application.Users.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CRM.API.Controllers.v1
{
    [ApiController]
    [ApiVersion(1.0)]
    [Route("v1/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<LoginResponse> Login([FromBody] LoginRequest request)
        {
            var result = await _mediator.Send(new LoginQuery(request.Login, request.Password));
            return new LoginResponse(result.Status, "");
        }
    }
}
