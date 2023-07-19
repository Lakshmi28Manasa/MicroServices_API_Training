namespace Mango.Web.Models
{
    public class ResponseDto
    {
        //It validates the response any datatype
        public object? Result { get; set; }

        //If the request is success or not
        public bool IsSuccess { get; set; } = true;

        //It displayes error or success message
        public string Message { get; set; } = "";
    }
}
