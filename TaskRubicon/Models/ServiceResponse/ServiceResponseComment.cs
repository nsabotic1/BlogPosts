namespace TaskRubicon.Models.ServiceResponse
{
    public class ServiceResponseComment<T>
    {
        public T? Comment { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }
}
