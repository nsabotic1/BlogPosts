using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskRubicon.Data;
using TaskRubicon.Dtos.CommentDtos;
using TaskRubicon.Models;
using TaskRubicon.Models.ServiceResponse;

namespace TaskRubicon.Services.CommentService
{
    public class CommentService : ICommentService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public CommentService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<ServiceResponseComments<List<GetCommentDto>>> GetCommentByBlogPostSlug(string slug)
        {
            var serviceResponse = new ServiceResponseComments<List<GetCommentDto>>();
            try
            {
                var blogId = _context.BlogPosts
                    .Where(x => x.Slug == slug)
                    .Select(x => x.Id);

                if (!blogId.Any())
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Slug doesn't exist";
                    return serviceResponse;
                }

                var dbComments = await _context.Comments
                    .Where(x => blogId.Contains(x.BlogPostId))
                    .ToListAsync();
                serviceResponse.Comments = dbComments
                    .Select(comments => _mapper.Map<GetCommentDto>(comments))
                    .ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponseComment<GetCommentDto>> GetSingleCommentByBlogPostSlug(string slug, int id)
        {
            var serviceResponse = new ServiceResponseComment<GetCommentDto>();
            try
            {
                var blogId = _context.BlogPosts
                    .Where(x => x.Slug == slug)
                    .Select(x => x.Id);

                if (!blogId.Any())
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Slug doesn't exist";
                    return serviceResponse;
                }

                var dbComments = await _context.Comments
                    .Where(x => blogId.Contains(x.BlogPostId))
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (dbComments == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Comment with that id doesn't exist in this blog post!";
                    return serviceResponse;
                }
                serviceResponse.Comment = _mapper.Map<GetCommentDto>(dbComments);

            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
        public async Task<ServiceResponseComments<GetCommentDto>> AddComment(string slug, AddCommentDto newComment)
        {
            var serviceResponse = new ServiceResponseComments<GetCommentDto>();
            try
            {
                if (string.IsNullOrWhiteSpace(newComment.Body))
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Body can't be empty!";
                    return serviceResponse;
                }
                var comment = _mapper.Map<Comment>(newComment);
                var blogId = await _context.BlogPosts
                    .Where(x => x.Slug == slug).Select(x => x.Id)
                    .SingleOrDefaultAsync();
                comment.BlogPostId = blogId;
                _context.Comments.Add(comment);
                await _context.SaveChangesAsync();
                serviceResponse.Comments = _mapper.Map<GetCommentDto>(comment);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponseComments<List<GetCommentDto>>> DeleteComment(string slug, int id)
        {
            var serviceResponse = new ServiceResponseComments<List<GetCommentDto>>();

            try
            {
                var blogId = await _context.BlogPosts
                    .Where(x => x.Slug == slug).Select(x => x.Id)
                    .SingleOrDefaultAsync();
                if (blogId == 0)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Slug doesn't exist!";
                    return serviceResponse;
                }
                var comment = await _context.Comments
                    .Where(x => x.Id == id && x.BlogPostId == blogId)
                    .SingleOrDefaultAsync();
                if (comment == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Comment with that id doesn't exist in this blog post!";
                    return serviceResponse;
                }
                var comment2 = _mapper.Map<Comment>(comment);
                _context.Comments.Remove(comment2);
                await _context.SaveChangesAsync();
                serviceResponse.Comments = await _context.Comments
                    .Where(x => x.BlogPostId == blogId)
                    .Select(s => _mapper.Map<GetCommentDto>(s))
                    .ToListAsync();
                serviceResponse.Message = "Comment deleted!";

            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
