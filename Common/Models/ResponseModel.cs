

namespace Common.Models
{
    public class ResponseModel<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public ResponseModel(bool success, string message, T data = default)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public static ResponseModel<T> SuccessResponse(T data, string message = "Request successful")
        {
            return new ResponseModel<T>(true, message, data);
        }

        public static ResponseModel<T> ErrorResponse(string message)
        {
            return new ResponseModel<T>(false, message);
        }
    }
}
