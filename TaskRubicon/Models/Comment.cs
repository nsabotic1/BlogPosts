namespace TaskRubicon.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime createdAt { get; set; } = DateTime.UtcNow;
        public DateTime updatedAt { get; set; } = DateTime.UtcNow;
        public string Body { get; set; } = string.Empty;
        public int BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
