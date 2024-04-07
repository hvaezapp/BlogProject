using BlogProject.Application.Contract.Persistence;
using BlogProject.Application.Dto.Category;
using BlogProject.Application.Features.Category.Request.Queries;
using MediatR;

namespace BlogProject.Application.Features.Category.Handler.Queries
{
    public class GetAllCategoriesQueryRequestHandler : IRequestHandler<GetAllCategoriesQueryRequest, ApiResponseResult>
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetAllCategoriesQueryRequestHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<ApiResponseResult> Handle(GetAllCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var api = new ApiResponseResult();

            try
            {
               
                // get all categories from database 
                var categories = await _categoryRepository
                                        .GetAll();

                var result = categories.Select(a => new CategoryDto
                {
                    Id = a.Id,
                    Title = a.Title

                }).ToList();


                api.Success(result);
            }
            catch (Exception ex)
            {
                api.Error(ex.Message);
            }

            return api;
        }
    }
}
