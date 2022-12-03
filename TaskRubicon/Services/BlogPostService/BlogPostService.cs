using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskRubicon.Data;
using TaskRubicon.Dtos.BlogPostDtos;
using TaskRubicon.Helpers;
using TaskRubicon.Models;
using TaskRubicon.Models.ServiceResponse;

namespace TaskRubicon.Services.BlogPostService
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IHelperMethods _helperMethods;

        public BlogPostService(IMapper mapper, DataContext context,IHelperMethods helperMethods)
        {
            _mapper = mapper;
            _context = context;
            _helperMethods = helperMethods;
        }

        public async Task<ServiceResponseBlogPost<GetBlogPostDto>> AddBlogPost(AddBlogPostDto newBlogPost)
        {
            var serviceResponse = new ServiceResponseBlogPost<GetBlogPostDto>();
            try
            {
                BlogPost blog = _mapper.Map<BlogPost>(newBlogPost);
                var slug = _helperMethods.CreateSlug(blog.Title);

                if (string.IsNullOrWhiteSpace(slug)
                    || string.IsNullOrWhiteSpace(blog.Body)
                    || string.IsNullOrWhiteSpace(blog.Description))
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Field can't be empty!";
                    return serviceResponse;
                }

                foreach (var item in _context.BlogPosts
                    .Select(x => x.Slug)
                    .ToList())
                {
                    if (item == slug)
                    {
                        serviceResponse.Success = false;
                        serviceResponse.Message = "Slug with that name already exists!";
                        return serviceResponse;
                    }
                }

                blog.Slug = slug;

                if (newBlogPost.TagList != null)
                {
                    var tagList = new List<Tag>();

                    foreach (var item in newBlogPost.TagList)
                    {
                        if (string.IsNullOrWhiteSpace(item))
                        {
                            serviceResponse.Success = false;
                            serviceResponse.Message = "Titles in tagList can't be empty!";
                            return serviceResponse;
                        }
                        var tag = new Tag
                        {
                            BlogPostId = blog.Id,
                            Title = item
                        };
                        tagList.Add(tag);
                    }
                    blog.TagList = tagList;
                }

                _context.BlogPosts.Add(blog);
                await _context.SaveChangesAsync();
                serviceResponse.BlogPost = _mapper.Map<GetBlogPostDto>(blog);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponseBlogPost<List<GetBlogPostDto>>> DeleteBlogPost(string slug)
        {
            var serviceResponse = new ServiceResponseBlogPost<List<GetBlogPostDto>>();
            try
            {
                var blog = await _context.BlogPosts
                    .FirstOrDefaultAsync(b => b.Slug == slug);
                if (blog == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Slug is not found";
                    return serviceResponse;
                }
                _context.BlogPosts.Remove(blog);
                await _context.SaveChangesAsync();
                serviceResponse.BlogPost = _context.BlogPosts
                    .Select(b => _mapper.Map<GetBlogPostDto>(b))
                    .ToList();
                serviceResponse.Message = "Blog post deleted!";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponseBlogPosts<List<GetBlogPostDto>>> GetAllBlogPosts(string? tag)
        {
            var serviceResponse = new ServiceResponseBlogPosts<List<GetBlogPostDto>>();
            try
            {
                var dbBlogPosts = await _context.BlogPosts
                    .Include(b => b.TagList)
                    .OrderByDescending(b => b.createdAt)
                    .ToListAsync();
                if (tag != null) dbBlogPosts = dbBlogPosts
                        .Where(b => b.TagList
                            .Select(x => x.Title.ToLowerInvariant())
                            .Contains(tag.ToLowerInvariant()))
                        .ToList();
                serviceResponse.BlogPosts = dbBlogPosts
                    .Select(b => _mapper.Map<GetBlogPostDto>(b))
                    .ToList();
                int BlogPostsCount = dbBlogPosts.Count();
                serviceResponse.PostsCount = BlogPostsCount;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponseBlogPost<GetBlogPostDto>> GetBlogPostBySlug(string slug)
        {
            var serviceResponse = new ServiceResponseBlogPost<GetBlogPostDto>();
            try
            {
                var dbBlog = await _context.BlogPosts
                    .Include(b => b.TagList)
                    .FirstOrDefaultAsync(b => b.Slug == slug);

                if (dbBlog == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Slug is not found";
                    return serviceResponse;
                }
                serviceResponse.BlogPost = _mapper.Map<GetBlogPostDto>(dbBlog);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponseBlogPost<GetBlogPostDto>> UpdateBlogPost(string slug, UpdateBlogPostDto updatedBlogPost)
        {
            var serviceResponse = new ServiceResponseBlogPost<GetBlogPostDto>();
            try
            {
                var blog = await _context.BlogPosts
                    .FirstOrDefaultAsync(b => b.Slug == slug);

                _mapper.Map(updatedBlogPost, blog);
                if (blog == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Slug is not found";
                    return serviceResponse;
                }
                if (updatedBlogPost.Title != null)
                {
                    string str1 = _helperMethods.CreateSlug(updatedBlogPost.Title);

                    foreach (var item in _context.BlogPosts
                        .Select(x => x.Slug)
                        .ToList())
                    {
                        if (item == str1)
                        {
                            serviceResponse.Success = false;
                            serviceResponse.Message = "Slug with that name already exists!";
                            return serviceResponse;
                        }
                    }
                    blog.Slug = str1;
                }
                blog.updatedAt = DateTime.UtcNow;
                await _context.SaveChangesAsync();
                serviceResponse.BlogPost = _mapper.Map<GetBlogPostDto>(blog);
                serviceResponse.Message = "Your blog post has been updated !";
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
