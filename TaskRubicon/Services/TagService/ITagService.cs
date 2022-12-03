using TaskRubicon.Dtos.TagDtos;
using TaskRubicon.Models.ServiceResponse;

namespace TaskRubicon.Services.TagService
{
    public interface ITagService
    {
        Task<ServiceResponseTag<List<GetTagDto>>> GetAllTags();
    }
}
