using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Task Update(T entity);
        Task Delete(T entity);
        Task DeleteById(long id);

    }
}
