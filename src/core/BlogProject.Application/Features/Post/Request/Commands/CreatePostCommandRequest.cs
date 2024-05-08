using BlogProject.Application.Dto.Post;
using MediatR;

namespace BlogProject.Application.Features.Post.Request.Commands
{
    public class CreatePostCommandRequest : IRequest<ApiResponseResult>
    {
        public CreatePostDto CreatePostDto { get; set; }
    }
}
