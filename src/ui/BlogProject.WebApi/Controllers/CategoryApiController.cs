using BlogProject.Domain.entity;
using BlogProject.Persistence.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogProject.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryApiController : ControllerBase
    {
        private readonly BlogDB _context;

        public CategoryApiController(BlogDB context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            await _context.Category.AddAsync(category);
            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            return Ok( await _context.Category.ToListAsync());
        }


    }
}
