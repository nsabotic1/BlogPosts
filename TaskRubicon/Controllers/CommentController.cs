using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskRubicon.Dtos.CommentDtos;
using TaskRubicon.Models.ServiceResponse;
using TaskRubicon.Services.CommentService;

namespace TaskRubicon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet("{slug}/comments")]
        public async Task<IActionResult> GetCommentsBySlug(string slug)
        {
            try
            {
                var serviceResponse = await _commentService.GetCommentByBlogPostSlug(slug);
                if (serviceResponse.Comments == null)
                {
                    return BadRequest(serviceResponse);
                }
                return Ok(serviceResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{slug}/{id}/comments")]
        public async Task<IActionResult> GetSingleCommentBySlug(string slug, int id)
        {
            try
            {
                var serviceResponse = await _commentService.GetSingleCommentByBlogPostSlug(slug, id);
                if (serviceResponse.Comment == null)
                {
                    return BadRequest(serviceResponse);
                }
                return Ok(serviceResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("{slug}/comments")]
        public async Task<ActionResult<ServiceResponseComments<GetCommentDto>>> AddComment(string slug, AddCommentDto newComment)
        {
            try
            {
                var serviceResponse = await _commentService.AddComment(slug, newComment);
                if (serviceResponse.Comments == null)
                {
                    return BadRequest(serviceResponse);
                }
                return Ok(serviceResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{slug}/comments/{id}")]
        public async Task<IActionResult> DeleteComment(string slug, int id)
        {
            try
            {
                var serviceResponse = await _commentService.DeleteComment(slug, id);
                if (serviceResponse.Comments == null)
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
