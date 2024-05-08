namespace BlogProject.Application.Dto.Post
{
    public class GetPostDto : CreatePostDto
    {
        public long Id { get; set; }
        public int ViewCount { get; set; }
    }
}
