using BlogProject.Application.Contract.Persistence;
using BlogProject.Application.Features.Category.Request.Queries;
using MediatR;

namespace BlogProject.Application.Features.Category.Handler.Queries
{
    public class GetAllCategoriesQueryRequestHandler : IRequestHandler<GetAllCategoriesQueryRequest, IEnumerable<Domain.entity.Category>>
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetAllCategoriesQueryRequestHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Domain.entity.Category>> Handle(GetAllCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            return await _categoryRepository
                                         .GetAll();
        }
    }
}
