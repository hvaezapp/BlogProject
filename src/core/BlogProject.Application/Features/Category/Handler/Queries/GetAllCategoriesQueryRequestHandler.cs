using AutoMapper;
using BlogProject.Application.Contract.Persistence;
using BlogProject.Application.Dto.Category;
using BlogProject.Application.Features.Category.Request.Queries;
using MediatR;

namespace BlogProject.Application.Features.Category.Handler.Queries
{
    public class GetAllCategoriesQueryRequestHandler : IRequestHandler<GetAllCategoriesQueryRequest, ApiResponseResult>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetAllCategoriesQueryRequestHandler(ICategoryRepository categoryRepository , 
                 IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<ApiResponseResult> Handle(GetAllCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var api = new ApiResponseResult();

            try
            {

                // get all categories from database 
                var categories = await _categoryRepository
                                                  .GetAll();



                // auto mapping 
                var result = _mapper
                                 .Map<List<GetCategoryDto>>(categories);


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
