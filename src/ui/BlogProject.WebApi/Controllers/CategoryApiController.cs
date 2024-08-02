using BlogProject.Application;
using BlogProject.Application.Dto.Category;
using BlogProject.Application.Features.Category.Request.Commands;
using BlogProject.Application.Features.Category.Request.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.WebApi.Controllers
{

    public class CategoryApiController(IMediator _mediator) : BaseController
    {



        /// <summary>
        /// دریافت لیست دسته بندی ها
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public async Task<ApiResponseResult> GetAll()
        {
            return await _mediator.Send(new GetAllCategoriesQueryRequest());

        }




        /// <summary>
        /// ایجاد دسته بندی جدید
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task<ApiResponseResult> Create([FromBody] CreateCategoryDto category)
        {

            return await _mediator.Send(new CreateCategoryCommandRequest
            {
                CreateCategoryDto = category
            });

        }




        /// <summary>
        ///  اپدیت دسته بندی موجود
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>

        [HttpPut]
        public async Task<ApiResponseResult> Update([FromBody] UpdateCategoryDto category)
        {
            return await _mediator.Send(new UpdateCategoryCommandRequest { UpdateCategoryDto = category });
        }





        /// <summary>
        /// حدف دسته بندی خاص
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete]
        public async Task<ApiResponseResult> Delete(long id)
        {
            return await _mediator.Send(new DeleteCategoryCommandRequest { Id = id });
        }



    }
}
