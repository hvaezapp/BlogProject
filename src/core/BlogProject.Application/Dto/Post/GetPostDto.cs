using BlogProject.Application.Dto.Category;
using BlogProject.Application.Dto.PostTag;

namespace BlogProject.Application.Dto.Post
{
    public class GetPostDto : UpdatePostDto
    {
        public int ViewCount { get; set; }

        public GetCategoryDto Category { get; set; }
        public List<GetPostTagDto> PostTags { get; set; } = [];
    }
}
