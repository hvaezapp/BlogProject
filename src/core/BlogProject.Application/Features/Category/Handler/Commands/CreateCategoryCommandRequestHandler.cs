using AutoMapper;
using BlogProject.Application.Contract.Persistence;
using BlogProject.Application.Dto.Category;
using BlogProject.Application.Dto.Category.Validator;
using BlogProject.Application.Features.Category.Request.Commands;
using MediatR;

namespace BlogProject.Application.Features.Category.Handler.Commands
{
    public class CreateCategoryCommandRequestHandler : IRequestHandler<CreateCategoryCommandRequest, ApiResponseResult>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CreateCategoryCommandRequestHandler(ICategoryRepository categoryRepository,
             IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<ApiResponseResult> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var api = new ApiResponseResult();

            try
            {
                var validator = new CreateCategoryDtoValidator();

                var validateResult = validator.Validate(request.CreateCategoryDto);

                // check data is valid
                if (validateResult.IsValid)
                {
                    // add data to table
                    var newCategory = _mapper
                                         .Map<Domain.entity.Category>(request.CreateCategoryDto);

                    var result = await _categoryRepository
                                           .Create(newCategory);

                    await _categoryRepository.SaveAsync();

                    var addedCategory = _mapper
                                           .Map<GetCategoryDto>(result);

                    api.Success(addedCategory);

                }
                else
                {
                    api.ValidationError(validateResult.Errors.Select(s => s.ErrorMessage).ToList());
                }


            }
            catch (Exception ex)
            {
                api.Error(ex.Message);
            }

            return api;

        }
    }
}
