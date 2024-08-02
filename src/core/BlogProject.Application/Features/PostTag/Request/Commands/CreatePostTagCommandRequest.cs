using BlogProject.Application.Dto.PostTag;
using MediatR;

namespace BlogProject.Application.Features.PostTag.Request.Commands
{
    public class CreatePostTagCommandRequest : IRequest<ApiResponseResult>
    {
        public CreatePostTagDto CreatePostTagDto { get; set; }
    }
}
