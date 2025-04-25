using Consultoria.Inversion.Application.Features;
using Microsoft.AspNetCore.Mvc;
using Consultoria.Inversion.Application.Exceptions;
using Consultoria.Inversion.Application.Database.User.Commands.CreateUser;
using Consultoria.Inversion.Application.Database.User.Commands.UpdateUser;
using Consultoria.Inversion.Application.Database.User.Commands.UpdateUserPassword;
using Consultoria.Inversion.Application.Database.User.Commands.DeleteUser;
using Consultoria.Inversion.Application.Database.User.Queries.GetAllUsers;
using Consultoria.Inversion.Application.Database.User.Queries.GetUserByEmailAndPass;
using Consultoria.Inversion.Application.Database.User.Queries.GetUserById;
using FluentValidation;

namespace Consultoria.Inversion.Api.Controllers
{
    [ApiController]
    [Route("api/v1/user")]
    [TypeFilter(typeof(ExcepctionManager))]
    public class UserController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create(
            [FromBody] CreateUserModel model,
            [FromServices] ICreateUserCommand createUserCommand,
            [FromServices] IValidator<CreateUserModel> validator
            )
        {
            var validate = await validator.ValidateAsync(model);
            if (!validate.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest,validate.Errors));
            var data = await createUserCommand.Execute(model);
            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created,data,"User se creo correctamente"));
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(
            [FromBody] UpdateUserModel model, 
            [FromServices] IUpdateUserCommand updateUserCommand,
            [FromServices] IValidator<UpdateUserModel> validator
            )
        {
            var validate = await validator.ValidateAsync(model);
            if (!validate.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest,validate.Errors));
            var data = await updateUserCommand.Execute(model);
            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK,data,"User se actualizo correctamente"));
        }

        [HttpPut("updatepass")]
        public async Task<IActionResult> UpdatePassword(
            [FromBody]UpdateUserPasswordModel model, 
            [FromServices] IUpdateUserPasswordCommand updateUserPasswordCommand,
            [FromServices] IValidator<UpdateUserPasswordModel> validator
            )
        {
            var validate = await validator.ValidateAsync(model);
            if (!validate.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest,validate.Errors));
            var data = await updateUserPasswordCommand.Execute(model);
            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK,data,"Password de User se actualizo correctamente"));
        }
        [HttpDelete("delete/{UserId}")]
        public async Task<IActionResult> Delete([FromServices] IDeleteUserCommand deleteUserCommand, int UserId)
        {
            if (UserId <= 0)
                return StatusCode(StatusCodes.Status400BadRequest,ResponseApiService.Response(StatusCodes.Status400BadRequest));
            
            var data = await deleteUserCommand.Execute(UserId);
            
            if (!data)
                return StatusCode(StatusCodes.Status404NotFound,ResponseApiService.Response(StatusCodes.Status404NotFound));

            return StatusCode(StatusCodes.Status200OK,ResponseApiService.Response(StatusCodes.Status200OK,data,"User se elimino correctamente"));
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllUsers([FromServices] IGetAllUsersQuery getAllUsersQuery)
        {
            var data = await getAllUsersQuery.Execute();
            if (data == null || !data.Any())
                return StatusCode(StatusCodes.Status404NotFound,ResponseApiService.Response(StatusCodes.Status404NotFound));
            return StatusCode(StatusCodes.Status200OK,ResponseApiService.Response(StatusCodes.Status200OK,data));
        }

        [HttpGet("get-by-id/{UserId}")]
        public async Task<IActionResult> GetUser(int UserId, [FromServices] IGetUserByIdQuery getUserByIdQuery)
        {
            if (UserId == 0)
                return StatusCode(StatusCodes.Status400BadRequest,ResponseApiService.Response(StatusCodes.Status400BadRequest));
            var data = await getUserByIdQuery.Execute(UserId);
            if (data == null)
                return StatusCode(StatusCodes.Status404NotFound,ResponseApiService.Response(StatusCodes.Status404NotFound));
            return StatusCode(StatusCodes.Status200OK,ResponseApiService.Response(StatusCodes.Status200OK,data));
        }
        
        [HttpGet("get-by-email-password/{email}/{password}")]
        public async Task<IActionResult> GetUserEmailPassword(
            string email, string password,
            [FromServices] IGetUserByEmailAndPassQuery getUserByEmailAndPassQuery,
            [FromServices] IValidator<(string, string)> validator
            )
        {
            var validate = await validator.ValidateAsync((email,password));
            if (!validate.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest,validate.Errors));
            var data = await getUserByEmailAndPassQuery.Execute(email,password);
            if (data == null)
                return StatusCode(StatusCodes.Status404NotFound,ResponseApiService.Response(StatusCodes.Status404NotFound));
            return StatusCode(StatusCodes.Status200OK,ResponseApiService.Response(StatusCodes.Status200OK,data));
        }
    }
}