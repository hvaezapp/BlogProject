using System.ComponentModel.DataAnnotations;

namespace BlogProject.Application.Dto.Category
{
    public class CreateCategoryDto
    {
        //[Required(AllowEmptyStrings = false , ErrorMessage = "عنوان دسته بندی نمی تواند خالی باشد")]
        public string Title { get; set; } 
    }
}
