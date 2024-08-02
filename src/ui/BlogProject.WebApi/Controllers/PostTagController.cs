using BlogProject.Application;
using BlogProject.Application.Dto.PostTag;
using BlogProject.Application.Features.PostTag.Request.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.WebApi.Controllers
{
    public class PostTagController : BaseController
    {
        private readonly IMediator _mediator;
        public PostTagController(IMediator mediator)
        {
             _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponseResult>> Create([FromBody] CreatePostTagDto dto)
        {
           var result = await _mediator.Send(new CreatePostTagCommandRequest { CreatePostTagDto = dto });
           return Ok(result);
        }

    }
}
