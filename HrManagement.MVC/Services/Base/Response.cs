namespace HrManagement.MVC.Services.Base
{
    public class Response<T>
    {
        public string Messange { get; set; }
        public string ValidationError { get; set; }
        public bool Success { get; set; }
        public T Data { get; set; }
    }
}
