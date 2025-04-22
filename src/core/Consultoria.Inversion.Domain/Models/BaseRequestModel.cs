namespace Consultoria.Inversion.Domain.Models
{
    public class BaseRequestModel
    {
        public int StatusCode { get; set; }
        public bool Success { get; set; }
        public string? Message { get; set; }
        public dynamic? Data { get; set; }
    }
}