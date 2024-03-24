using BlogProject.Application.Contract.Persistence;
using BlogProject.Domain.entity;
using BlogProject.Persistence.Context;

namespace BlogProject.Persistence.Repositories
{
    public class PostTagRepository : Repository<PostTag>, IPostTagRepository
    {
        private readonly BlogDB _context;
        public PostTagRepository(BlogDB context) : base(context)
        {
            _context = context;
        }
    }
}
