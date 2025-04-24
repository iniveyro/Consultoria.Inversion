using Consultoria.Inversion.Application.Database.Broker.Commands.CreateBroker;
using Consultoria.Inversion.Application.Database.Broker.Commands.DeleteBroker;
using Consultoria.Inversion.Application.Database.Broker.Commands.UpdateBroker;
using Consultoria.Inversion.Application.Database.Broker.Queries.GetAllBroker;
using Consultoria.Inversion.Application.Database.Broker.Queries.GetBrokerByDNI;
using Consultoria.Inversion.Application.Database.Broker.Queries.GetBrokerById;
using Consultoria.Inversion.Application.Exceptions;
using Consultoria.Inversion.Application.Features;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Consultoria.Inversion.Api.Controllers
{
    [ApiController]
    [Route("api/v1/broker")]
    [TypeFilter(typeof(ExcepctionManager))]
    public class BrokerController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create(
            [FromBody] CreateBrokerModel model, 
            [FromServices] ICreateBrokerCommand createBrokerCommand,
            [FromServices] IValidator<CreateBrokerModel> validator
            )
        {
            var validate = await validator.ValidateAsync(model);
            if (!validate.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest,validate.Errors));
            var data = await createBrokerCommand.Execute(model);
            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created,data,"Broker se creo correctamente"));
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(
            [FromBody] UpdateBrokerModel model, 
            [FromServices] IUpdateBrokerCommand updateBrokerCommand,
            [FromServices] IValidator<UpdateBrokerModel> validator
            )
        {
            var validate = await validator.ValidateAsync(model);
            if (!validate.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest,validate.Errors));
            var data = await updateBrokerCommand.Execute(model);
            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK,data,"Broker se actualizo correctamente"));
        }

        [HttpDelete("delete/{BrokerID}")]
        public async Task<IActionResult> Delete(int BrokerID, [FromServices] IDeleteBrokerCommand deleteBrokerCommand)
        {
            if (BrokerID <= 0)
                return StatusCode(StatusCodes.Status400BadRequest,ResponseApiService.Response(StatusCodes.Status400BadRequest));
            var data = await deleteBrokerCommand.Execute(BrokerID);
            if (!data)
                return StatusCode(StatusCodes.Status404NotFound,ResponseApiService.Response(StatusCodes.Status404NotFound));

            return StatusCode(StatusCodes.Status200OK,ResponseApiService.Response(StatusCodes.Status200OK,data,"Broker se elimino correctamente"));
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll([FromServices] IGetAllBrokersQuery getAllBrokersQuery)
        {
            var data = await getAllBrokersQuery.Execute();
            if (data == null)
                return StatusCode(StatusCodes.Status404NotFound,ResponseApiService.Response(StatusCodes.Status404NotFound));
            return StatusCode(StatusCodes.Status200OK,ResponseApiService.Response(StatusCodes.Status200OK,data));
        }

        [HttpGet("get-by-dni/{DNI}")]
        public async Task<IActionResult> GetByDNI(int DNI, [FromServices] IGetBrokerByDNIQuery getBrokerByDNIQuery)
        {
            if (DNI<=0)
                return StatusCode(StatusCodes.Status400BadRequest,ResponseApiService.Response(StatusCodes.Status400BadRequest));
            var data = await getBrokerByDNIQuery.Execute(DNI);
            if (data == null)
                return StatusCode(StatusCodes.Status404NotFound,ResponseApiService.Response(StatusCodes.Status404NotFound));
            return StatusCode(StatusCodes.Status200OK,ResponseApiService.Response(StatusCodes.Status200OK,data));
        }

        [HttpGet("get-by-id/{BrokerId}")]
        public async Task<IActionResult> GetById(int BrokerId, [FromServices] IGetBrokerByIdQuery getBrokerById)
        {
            if (BrokerId<=0)
                return StatusCode(StatusCodes.Status400BadRequest,ResponseApiService.Response(StatusCodes.Status400BadRequest));
            var data = await getBrokerById.Execute(BrokerId);
            if (data == null)
                return StatusCode(StatusCodes.Status404NotFound,ResponseApiService.Response(StatusCodes.Status404NotFound));
            return StatusCode(StatusCodes.Status200OK,ResponseApiService.Response(StatusCodes.Status200OK,data));
        }
    }
}