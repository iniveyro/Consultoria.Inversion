using Consultoria.Inversion.Application.Features;
using Microsoft.AspNetCore.Mvc;
using Consultoria.Inversion.Application.Exceptions;
using Consultoria.Inversion.Application.Database.User;
using Consultoria.Inversion.Application.Database.User.Commands.CreateUser;

namespace Consultoria.Inversion.Api.Controllers
{
    [ApiController]
    [Route("api/v1/user")]
    [TypeFilter(typeof(ExcepctionManager))]
    public class UserController : ControllerBase
    {
        public UserController()
        {
            
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateUserModel model, [FromServices] ICreateUserCommand createUserCommand)
        {
            var data = await createUserCommand.Execute(model);
            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created,model,"User se creo correctamente"));
        }
    }
}