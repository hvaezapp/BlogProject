using BlogProject.Application.Contract.Persistence;
using BlogProject.Domain.entity;
using BlogProject.Persistence.Context;

namespace BlogProject.Persistence.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
       
        public CategoryRepository(BlogDB context) : base(context)
        {

        }
    }
}
