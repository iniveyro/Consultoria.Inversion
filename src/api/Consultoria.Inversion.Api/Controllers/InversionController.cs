using Consultoria.Inversion.Application.Database.Inversion.Commands.CreateInversion;
using Consultoria.Inversion.Application.Database.Inversion.Queries.GetAllInversiones;
using Consultoria.Inversion.Application.Database.Inversion.Queries.GetInversionByDNI;
using Consultoria.Inversion.Application.Database.Inversion.Queries.GetInversionByTipo;
using Consultoria.Inversion.Application.Exceptions;
using Consultoria.Inversion.Application.Features;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Consultoria.Inversion.Api.Controllers
{
    [ApiController]
    [Route("api/v1/inversion")]
    [TypeFilter(typeof(ExcepctionManager))]

    public class InversionController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create(
            [FromBody] CreateInversionModel model,
            [FromServices] ICreateInversionCommand createInversionCommand,
            [FromServices] IValidator<CreateInversionModel> validator)
        {
            var validate = await validator.ValidateAsync(model);
            if (!validate.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest,validate.Errors));
            var data = await createInversionCommand.Execute(model);
            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created,data,"Inversion se creo correctamente"));
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll([FromServices] IGetAllInversionesQuery getAllInversionesQuery)
        {
            var data = getAllInversionesQuery.Execute();
            if (data == null)
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound));
            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK));
        }

        [HttpGet("get-by-dni")]
        public async Task<IActionResult> GetByDNI([FromQuery]int DNI, [FromServices] IGetInversionByDNIQuery getInversionByDNIQuery)
        {
            if (DNI == 0)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));
            var data = await getInversionByDNIQuery.Execute(DNI);
            if (data == null)
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound));
            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK,data));
        }

        [HttpGet("get-by-tipo")]
        public async Task<IActionResult> GetByTipo([FromQuery]string Tipo, [FromServices] IGetInversionByTipoQuery getInversionByTipoQuery)
        {
            var data = await getInversionByTipoQuery.Execute(Tipo);
            if (data == null)
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound));
            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK,data));
        }
    }
}