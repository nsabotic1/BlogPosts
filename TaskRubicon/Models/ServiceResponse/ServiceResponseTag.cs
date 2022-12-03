namespace TaskRubicon.Models.ServiceResponse
{
    public class ServiceResponseTag<T>
    {
        public T? Tags { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }
}
