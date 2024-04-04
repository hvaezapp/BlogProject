using BlogProject.Application.Dto.Category;
using MediatR;

namespace BlogProject.Application.Features.Category.Request.Queries
{
    public class GetAllCategoriesQueryRequest : IRequest<IEnumerable<CategoryDto>>
    {

    }
}
