using FluentValidation;

namespace BlogProject.Application.Dto.Category.Validator
{
    public class UpdateCategoryDtoValidator : AbstractValidator<UpdateCategoryDto>
    {
        public UpdateCategoryDtoValidator()
        {

            RuleFor(a => a.Id)
                            .NotNull()
                            .NotEmpty()
                            .WithMessage("مقدار ورودی نامعتبر است");



            RuleFor(a => a.Title)
                            .NotNull()
                            .NotEmpty()
                            .WithMessage("مقدار ورودی نامعتبر است");
        }
    }
}
