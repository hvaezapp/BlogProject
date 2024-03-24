using BlogProject.Application.Contract.Persistence;
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
        private readonly ICategoryRepository _categoryRepository;

        public CategoryApiController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            await _categoryRepository.Create(category);
            await  _categoryRepository.SaveAsync();
            return Ok();
        }


        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var data = await _categoryRepository.GetAll();
            return Ok(data);
        }


    }
}
