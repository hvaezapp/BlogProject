using AutoMapper;
using BlogProject.Application.Dto;
using BlogProject.Application.Dto.Category;
using BlogProject.Domain.entity;

namespace BlogProject.Application.Mapper
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CreateCategoryDto, Category>();
            CreateMap<UpdateCategoryDto, Category>();
        }
    }
}
