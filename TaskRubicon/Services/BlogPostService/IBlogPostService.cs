using TaskRubicon.Dtos.BlogPostDtos;
using TaskRubicon.Models.ServiceResponse;

namespace TaskRubicon.Services.BlogPostService
{
    public interface IBlogPostService
    {
        Task<ServiceResponseBlogPosts<List<GetBlogPostDto>>> GetAllBlogPosts(string? tag);
        Task<ServiceResponseBlogPost<GetBlogPostDto>> GetBlogPostBySlug(string slug);
        Task<ServiceResponseBlogPost<GetBlogPostDto>> AddBlogPost(AddBlogPostDto newBlogPost);
        Task<ServiceResponseBlogPost<GetBlogPostDto>> UpdateBlogPost(string slug, UpdateBlogPostDto updatedBlogPost);
        Task<ServiceResponseBlogPost<List<GetBlogPostDto>>> DeleteBlogPost(string slug);
    }
}
