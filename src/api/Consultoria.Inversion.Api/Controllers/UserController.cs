using Consultoria.Inversion.Api.Features;
using Microsoft.AspNetCore.Mvc;

namespace Consultoria.Inversion.Api.Controllers
{
    [ApiController]
    [Route("api/v1/user")]
    public class UserController : ControllerBase
    {
        public UserController()
        {
            
        }

        [HttpPost]
        public async Task<IActionResult> test ()
        {
            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK,"{}","Se ejecuto correctamente"));
        }        
    }
}