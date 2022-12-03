using TaskRubicon.Dtos.TagDtos;

namespace TaskRubicon.Dtos.BlogPostDtos
{
    public class GetBlogPostDto
    {
        public string Slug { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public List<GetTagDto> TagList { get; set; }
        public DateTime createdAt { get; set; } = DateTime.UtcNow;
        public DateTime updatedAt { get; set; } = DateTime.UtcNow;
    }
}

