using FluentValidation;

namespace BlogProject.Application.Dto.Category.Validator
{
    public class CreateCategoryDtoValidator : AbstractValidator<CreateCategoryDto>
    {
        public CreateCategoryDtoValidator()
        {
            RuleFor(a => a.Title)
                            .NotNull()
                            .NotEmpty()
                            .WithMessage("مقدار ورودی نامعتبر است");
        }
    }
}
