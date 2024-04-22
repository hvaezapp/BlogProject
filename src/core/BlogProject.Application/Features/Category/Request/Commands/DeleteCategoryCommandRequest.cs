using MediatR;

namespace BlogProject.Application.Features.Category.Request.Commands
{
    public class DeleteCategoryCommandRequest : IRequest<ApiResponseResult>
    {
        public long Id { get; set; }
    }
}
