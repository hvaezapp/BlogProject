using BlogProject.Application.Contract.Persistence;
using BlogProject.Domain.entity;
using BlogProject.Persistence.Context;

namespace BlogProject.Persistence.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        private readonly BlogDB _context;
        public PostRepository(BlogDB context) : base(context)
        {
            _context = context;
        }


        //.............
    }
}
