using BlogProject.Application.Contract.Persistence;
using BlogProject.Domain.entity;
using BlogProject.Persistence.Context;

namespace BlogProject.Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly BlogDB _context;
        public UserRepository(BlogDB context) : base(context)
        {
            _context = context;

        }
    }
}
