using AutoMapper;
using BlogProject.Application.Dto.Category;
using BlogProject.Application.Dto.Post;
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
            #endregion Category

            #region Post
            CreateMap<CreatePostDto, Post>();
            CreateMap<UpdatePostDto, Post>();
            CreateMap<Post, GetPostDto>();
            #endregion Post
        }
    }
}
