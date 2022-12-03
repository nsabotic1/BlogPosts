using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskRubicon.Dtos.BlogPostDtos;
using TaskRubicon.Services.BlogPostService;

namespace TaskRubicon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPostService _blogPostService;
        public BlogPostController(IBlogPostService blogPostService)
        {
            _blogPostService = blogPostService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get([FromQuery] string? tag)
        {
            try
            {
                var serviceResponse = await _blogPostService.GetAllBlogPosts(tag);
                return Ok(serviceResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{slug}")]
        public async Task<IActionResult> GetSingle(string slug)
        {
            try
            {
                var serviceResponse = await _blogPostService.GetBlogPostBySlug(slug);
                if (serviceResponse.BlogPost == null)
                {
                    return NotFound(serviceResponse);
                }
                return Ok(serviceResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{slug}")]
        public async Task<IActionResult> Delete(string slug)
        {
            try
            {
                var serviceResponse = await _blogPostService.DeleteBlogPost(slug);
                if (serviceResponse.BlogPost == null)
                {
                    return NotFound(serviceResponse);
                }
                return Ok(serviceResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddBlogPostDto newBlogPost)
        {
            try
            {
                var serviceResponse = await _blogPostService.AddBlogPost(newBlogPost);
                if (serviceResponse.BlogPost == null)
                {
                    return NotFound(serviceResponse);
                }
                return Ok(serviceResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromQuery] string slug, UpdateBlogPostDto updatedBlogPost)
        {
            try
            {
                var serviceResponse = await _blogPostService.UpdateBlogPost(slug, updatedBlogPost);
                if (serviceResponse.BlogPost == null)
                {
                    return NotFound(serviceResponse);
                }
                return Ok(serviceResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
