namespace TehranPortalV2.Models
{
    public class ResponseViewModel
    {
        public required bool IsSuccess { get; set; }
        public required int StatusCode { get; set; }
        public required string Message { get; set; }
        public object? Data { get; set; }
    }
}
