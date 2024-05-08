namespace BlogProject.Application.Dto.Post
{
    public class CreatePostDto
    {
        public long CategoryId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
