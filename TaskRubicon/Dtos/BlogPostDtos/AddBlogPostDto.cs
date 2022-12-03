namespace TaskRubicon.Dtos.BlogPostDtos
{
    public class AddBlogPostDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public List<string>? TagList { get; set; }
    }
}
