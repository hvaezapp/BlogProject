using BlogProject.Application.Dto.Post;
using MediatR;

namespace BlogProject.Application.Features.Post.Request.Commands
{
    public class UpdatePostCommandRequest : IRequest<ApiResponseResult>
    {
        public UpdatePostDto UpdatePostDto { get; set; }
    }
}
