using BlogProject.Application.Contract.Persistence;
using BlogProject.Application.Dto.Category;
using BlogProject.Application.Dto.Category.Validator;
using BlogProject.Application.Features.Category.Request.Commands;
using FluentValidation;
using MediatR;

namespace BlogProject.Application.Features.Category.Handler.Commands
{
    public class CreateCategoryCommandRequestHandler : IRequestHandler<CreateCategoryCommandRequest, CategoryDto>
    {
        private readonly ICategoryRepository _categoryRepository;

        public CreateCategoryCommandRequestHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<CategoryDto> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var validator = new CreateCategoryDtoValidator();

            var validateResult = validator.Validate(request.CreateCategoryDto);

            if (validateResult.IsValid)
            {
                var newCategory = new Domain.entity.Category
                {
                    Title = request.CreateCategoryDto.Title
                };

                var result = await _categoryRepository
                                       .Create(newCategory);

                await _categoryRepository.SaveAsync();

                return new CategoryDto
                {
                    Id = result.Id,
                    Title = result.Title,
                };
            }

            var error =  validateResult.Errors.Select(a=>a.ErrorMessage).FirstOrDefault();
            throw new Exception(error);

            
        }
    }
}
