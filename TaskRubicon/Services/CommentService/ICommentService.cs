using TaskRubicon.Dtos.CommentDtos;
using TaskRubicon.Models.ServiceResponse;

namespace TaskRubicon.Services.CommentService
{
    public interface ICommentService
    {
        Task<ServiceResponseComments<List<GetCommentDto>>> GetCommentByBlogPostSlug(string slug);
        Task<ServiceResponseComment<GetCommentDto>> GetSingleCommentByBlogPostSlug(string slug, int id);
        Task<ServiceResponseComments<GetCommentDto>> AddComment(string slug, AddCommentDto newComment);
        Task<ServiceResponseComments<List<GetCommentDto>>> DeleteComment(string slug, int id);
    }
}
