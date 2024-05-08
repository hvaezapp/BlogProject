using BlogProject.Application.Dto.Category;
using MediatR;

namespace BlogProject.Application.Features.Category.Request.Commands
{
    public class UpdateCategoryCommandRequest : IRequest<ApiResponseResult>
    {
        public UpdateCategoryDto UpdateCategoryDto { get; set; }
    }
}
