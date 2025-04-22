using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Consultoria.Inversion.Application.Features;

namespace Consultoria.Inversion.Application.Exceptions
{
    public class ExcepctionManager : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            context.Result = new ObjectResult(ResponseApiService.Response(
                StatusCodes.Status500InternalServerError, null, context.Exception.Message
            ));
            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        }
    }
}