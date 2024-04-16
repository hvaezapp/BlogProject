using AutoMapper;
using BlogProject.Application.Contract.Persistence;
using BlogProject.Application.Dto.Category.Validator;
using BlogProject.Application.Features.Category.Request.Commands;
using MediatR;

namespace BlogProject.Application.Features.Category.Handler.Commands
{
    public class UpdateCategoryCommandRequestHandler : IRequestHandler<UpdateCategoryCommandRequest, ApiResponseResult>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public UpdateCategoryCommandRequestHandler(ICategoryRepository categoryRepository,
                 IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<ApiResponseResult> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var api = new ApiResponseResult();

            try
            {
                // check validation
                var validations = new UpdateCategoryDtoValidator();
                var validationResult = validations.Validate(request.UpdateCategoryDto);

                if (validationResult.IsValid)
                {
                    var oldCategory = _mapper
                                       .Map<Domain.entity.Category>(request.UpdateCategoryDto);


                    await _categoryRepository.Update(oldCategory);
                    await _categoryRepository.SaveAsync();

                    api.Success(oldCategory);

                }
                else
                    api.ValidationError(validationResult.Errors.Select(a=>a.ErrorMessage).ToList());

               
            }
            catch (Exception ex)
            {
               api.Error(ex.Message);
            }

            return api;

        }
    }
}
