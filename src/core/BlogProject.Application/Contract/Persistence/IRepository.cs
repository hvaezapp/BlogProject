using System.Linq.Expressions;

namespace BlogProject.Application.Contract.Persistence
{
    public interface IRepository<T> where T : class
    {
        //CRUD

        //CREATE
        //READ
        //UPDATE
        //DELETE

        Task Create(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAll(Expression<Func<T,bool>> expression);
        Task Update(T entity);
        Task Delete(T entity);
        Task DeleteById(long id);
        Task<T> GetById(long id);
        Task<int> SaveAsync();

    }
}
