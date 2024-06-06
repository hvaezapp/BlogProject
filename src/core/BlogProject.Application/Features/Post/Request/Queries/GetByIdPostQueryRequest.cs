using MediatR;

namespace BlogProject.Application.Features.Post.Request.Queries
{
    public class GetByIdPostQueryRequest : IRequest<ApiResponseResult>
    {
        public long PostId { get; set; }
    }
}
