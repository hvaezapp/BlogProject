using BlogProject.Application.Dto.Post;
using BlogProject.Application.Features.Post.Request.Commands;
using BlogProject.Application.Features.Post.Request.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostApiController(IMediator _mediator) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllPostsQueryRequest());
            return Ok(result);
        }


        [HttpGet("{postId:long}")]
        public async Task<IActionResult> GetById(long postId)
        {
            var result = await _mediator.Send(new GetByIdPostQueryRequest { PostId = postId });
            return Ok(result);
        }



        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePostDto dto)
        {
            var result = await _mediator.Send(new CreatePostCommandRequest { CreatePostDto = dto });
            return Ok(result);
        }



        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdatePostDto dto)
        {
            var result = await _mediator.Send(new UpdatePostCommandRequest { UpdatePostDto = dto });
            return Ok(result); 
        }


    }
}
