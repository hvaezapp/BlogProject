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

        public CreateCategoryCommandRequestHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
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
                    var newCategory = new Domain.entity.Category
                    {
                        Title = request.CreateCategoryDto.Title
                    };

                    var result = await _categoryRepository
                                           .Create(newCategory);

                    await _categoryRepository.SaveAsync();

                    var addedCategory = new CategoryDto
                    {
                        Id = result.Id,
                        Title = result.Title,
                    };

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
