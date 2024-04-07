using BlogProject.Application.Dto.Category;
using MediatR;

namespace BlogProject.Application.Features.Category.Request.Commands
{
    public class CreateCategoryCommandRequest : IRequest<ApiResponseResult>
    {
        public CreateCategoryDto CreateCategoryDto { get; set; }
    }
}
