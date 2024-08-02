using AutoMapper;
using BlogProject.Application.Dto.Category;
using BlogProject.Application.Dto.Post;
using BlogProject.Application.Dto.PostTag;
using BlogProject.Domain.entity;
using Microsoft.Extensions.Hosting;

namespace BlogProject.Application.Mapper
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            #region Category
            CreateMap<Category, GetCategoryDto>();
            CreateMap<CreateCategoryDto, Category>();
            CreateMap<UpdateCategoryDto, Category>();
            #endregion

            #region Post
            CreateMap<CreatePostDto, Post>();
            CreateMap<UpdatePostDto, Post>();
            CreateMap<Post, GetPostDto>();
            #endregion 



            #region PostTag
            CreateMap<CreatePostTagDto, PostTag>();
            CreateMap<PostTag, GetPostTagDto>();
            #endregion
        }
    }
}
