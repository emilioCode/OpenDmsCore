namespace OpenDmsCore.Api.Responses
{
    public class ApiResponse
    {
        public string Code { get; set; } = "";
        public string Message { get; set; } = "";
        public bool Success { get; set; } = false;
        public object Data { get; set; }
    }
}
