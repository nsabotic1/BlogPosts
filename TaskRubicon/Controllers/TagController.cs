using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskRubicon.Dtos.TagDtos;
using TaskRubicon.Models.ServiceResponse;
using TaskRubicon.Services.TagService;

namespace TaskRubicon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ITagService _tagService;
        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponseTag<List<GetTagDto>>>> Get()
        {
            return Ok(await _tagService.GetAllTags());
        }
    }
}
