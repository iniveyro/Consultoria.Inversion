using Consultoria.Inversion.Application.Features;
using Microsoft.AspNetCore.Mvc;
using Consultoria.Inversion.Application.Exceptions;

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

        [HttpPost]
        public async Task<IActionResult> Test()
        {
            var number = int.Parse("asdasd");
            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK,"{}","Se ejecuto correctamente"));
        }        
    }
}