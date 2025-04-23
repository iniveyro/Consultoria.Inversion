using Consultoria.Inversion.Application.Features;
using Microsoft.AspNetCore.Mvc;
using Consultoria.Inversion.Application.Exceptions;
using Consultoria.Inversion.Application.Database.User;
using Consultoria.Inversion.Application.Database.User.Commands.CreateUser;
using Consultoria.Inversion.Application.Database.User.Commands.UpdateUser;
using Consultoria.Inversion.Application.Database.User.Commands.UpdateUserPassword;

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
            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created,data,"User se creo correctamente"));
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody]UpdateUserModel model, [FromServices]IUpdateUserCommand updateUserCommand)
        {
            var data = await updateUserCommand.Execute(model);
            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK,data,"User se actualizo correctamente"));
        }

        [HttpPut("updatepass")]
        public async Task<IActionResult> UpdatePassword([FromBody]UpdateUserPasswordModel model, [FromServices] IUpdateUserPasswordCommand updateUserPasswordCommand)
        {
            var data = await updateUserPasswordCommand.Execute(model);
            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK,data,"Password de User se actualizo correctamente"));
        }
    }
}