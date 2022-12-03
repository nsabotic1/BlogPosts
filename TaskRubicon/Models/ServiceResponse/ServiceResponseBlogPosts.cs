namespace TaskRubicon.Models.ServiceResponse
{
    public class ServiceResponseBlogPosts<T>
    {
        public T? BlogPosts { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
        public int PostsCount { get; set; } = 0;
    }
}
