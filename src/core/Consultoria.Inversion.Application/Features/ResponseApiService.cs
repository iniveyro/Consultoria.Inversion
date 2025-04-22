using Consultoria.Inversion.Domain.Models;

namespace Consultoria.Inversion.Application.Features
{
    public static class ResponseApiService
    {
        public static BaseRequestModel Response (int StatusCode, object? Data = null, string? Message = null)
        {
            bool Success = false;
            if (StatusCode >= 200 && StatusCode < 300)
                Success = true;
            var result = new BaseRequestModel
            {
                StatusCode = StatusCode,
                Success = Success,
                Data = Data,
                Message = Message,
            };
            return result;
        }
    }
}