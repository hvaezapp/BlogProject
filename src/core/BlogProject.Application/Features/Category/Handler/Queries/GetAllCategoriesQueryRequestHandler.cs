using BlogProject.Application.Contract.Persistence;
using BlogProject.Application.Dto.Category;
using BlogProject.Application.Features.Category.Request.Queries;
using MediatR;

namespace BlogProject.Application.Features.Category.Handler.Queries
{
    public class GetAllCategoriesQueryRequestHandler : IRequestHandler<GetAllCategoriesQueryRequest, IEnumerable<CategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetAllCategoriesQueryRequestHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<CategoryDto>> Handle(GetAllCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var categories = await _categoryRepository
                                         .GetAll();

            return categories.Select(a=> new CategoryDto
            {
                Id = a.Id,
                Title  = a.Title

            }).ToList();
        }
    }
}
