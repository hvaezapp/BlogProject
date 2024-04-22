using AutoMapper;
using BlogProject.Application.Contract.Persistence;
using BlogProject.Application.Features.Category.Request.Commands;
using MediatR;

namespace BlogProject.Application.Features.Category.Handler.Commands
{
    public class DeleteCategoryCommandRequestHandler(ICategoryRepository _categoryRepository) : IRequestHandler<DeleteCategoryCommandRequest, ApiResponseResult>
    {
        public async Task<ApiResponseResult> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var api = new ApiResponseResult();

            try
            {
                // validation
                if (request.Id <= 0)
                    api.ValidationError(new List<string> { "Id invalid" });
                else
                {
                    // delete
                    await _categoryRepository.DeleteById(request.Id);
                    await _categoryRepository.SaveAsync();

                    api.Success();
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
