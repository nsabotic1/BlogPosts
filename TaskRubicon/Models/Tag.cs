namespace TaskRubicon.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
