namespace TaskRubicon.Models.ServiceResponse
{
    public class ServiceResponseComments<T>
    {
        public T? Comments { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }
}
