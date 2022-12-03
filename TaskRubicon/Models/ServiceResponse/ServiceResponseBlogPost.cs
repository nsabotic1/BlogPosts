namespace TaskRubicon.Models.ServiceResponse
{
    public class ServiceResponseBlogPost<T>
    {
        public T? BlogPost { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }
}
