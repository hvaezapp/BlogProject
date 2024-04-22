using AutoMapper;
using BlogProject.Application.Dto;
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
            CreateMap<Category, CategoryDto>();
            CreateMap<CreateCategoryDto, Category>();
            CreateMap<UpdateCategoryDto, Category>();
            #endregion Category

            #region Post
            CreateMap<Post, PostDto>();
            #endregion Post
        }
    }
}
