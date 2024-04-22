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
            return Ok(await _mediator.Send(new GetAllPostsQueryRequest()));
        }

    }
}
