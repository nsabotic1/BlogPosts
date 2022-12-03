using AutoMapper;
using TaskRubicon.Dtos.BlogPostDtos;
using TaskRubicon.Dtos.CommentDtos;
using TaskRubicon.Dtos.TagDtos;
using TaskRubicon.Models;

namespace TaskRubicon
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<BlogPost, GetBlogPostDto>();
            CreateMap<AddBlogPostDto, BlogPost>().ForMember(x => x.TagList, t => t.Ignore());
            CreateMap<UpdateBlogPostDto, BlogPost>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Tag, GetTagDto>();
            CreateMap<AddTagDto, Tag>();

            CreateMap<Comment, GetCommentDto>();
            CreateMap<AddCommentDto, Comment>();

        }
    }
}
