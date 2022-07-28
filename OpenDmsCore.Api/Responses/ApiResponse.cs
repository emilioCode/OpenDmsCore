namespace OpenDmsCore.Api.Responses
{
    public class ApiResponse<T>
    {
        public ApiResponse(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; } = false;
    }
}
