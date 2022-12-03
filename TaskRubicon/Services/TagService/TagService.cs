using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskRubicon.Data;
using TaskRubicon.Dtos.TagDtos;
using TaskRubicon.Models.ServiceResponse;

namespace TaskRubicon.Services.TagService
{
    public class TagService : ITagService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public TagService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponseTag<List<GetTagDto>>> GetAllTags()
        {
            var serviceResponse = new ServiceResponseTag<List<GetTagDto>>();
            var dbBlogPosts = await _context.Tags.ToListAsync();
            serviceResponse.Tags = dbBlogPosts
                .Select(b => _mapper.Map<GetTagDto>(b))
                .ToList();
            return serviceResponse;
        }
    }
}
