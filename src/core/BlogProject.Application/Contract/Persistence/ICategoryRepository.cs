using BlogProject.Domain.entity;

namespace BlogProject.Application.Contract.Persistence
{
    public interface ICategoryRepository : IRepository<Category>
    {
        // Methods

        //Task<IEnumerable<Category>> GetCategoriesWithSpecificName(string title);

    }
}
