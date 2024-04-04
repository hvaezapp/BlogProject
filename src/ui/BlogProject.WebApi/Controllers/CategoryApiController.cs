using BlogProject.Application.Contract.Persistence;
using BlogProject.Application.Dto.Category;
using BlogProject.Application.Features.Category.Request.Commands;
using BlogProject.Application.Features.Category.Request.Queries;
using BlogProject.Domain.entity;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryApiController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMediator _mediator;

        public CategoryApiController(ICategoryRepository categoryRepository,
               IMediator mediator)
        {
            _categoryRepository = categoryRepository;
            _mediator = mediator;

        }


        /// <summary>
        /// دریافت لیست دسته بندی ها
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllCategoriesQueryRequest());
            return Ok(result);
        }



        /// <summary>
        /// ایجاد دسته بندی جدید
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCategoryDto category)
        {
         
            var result = await _mediator
                                    .Send(new CreateCategoryCommandRequest 
                                    { 
                                        CreateCategoryDto  = category
                                    });
            return Ok(result);
        }



        /// <summary>
        ///  اپدیت دسته بندی موجود
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Category category)
        {
            var entity = await _categoryRepository.Update(category);
            await _categoryRepository.SaveAsync();

            return Ok(entity);
        }



        /// <summary>
        /// حدف دسته بندی خاص
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete]
        public async Task<IActionResult> Delete(long id)
        {
            await _categoryRepository.DeleteById(id);
            await _categoryRepository.SaveAsync();

            return Ok();
        }

    }
}
