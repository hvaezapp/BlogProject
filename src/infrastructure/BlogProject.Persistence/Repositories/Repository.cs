using Azure.Core;
using BlogProject.Application.Contract.Persistence;
using BlogProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BlogProject.Persistence.Repositories
{

    public class Repository<T> : IRepository<T> where T : class
    {
        //inject database
        private readonly BlogDB _context;

        //introduce table
        private readonly DbSet<T> _table;

        public Repository(BlogDB context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public async Task<T> Create(T entity)
        {
            await _table.AddAsync(entity);
            return entity;
        }

        public async Task Delete(T entity)
        {
            _table.Remove(entity);
        }

        public async Task DeleteById(long id)
        {
            var findedEntity = await GetById(id);

            if (findedEntity is not null)
                _table.Remove(findedEntity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
           
            return await _table.ToListAsync();
        }


        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> expression)
        {
            return await _table
                           .AsNoTracking()
                           .Where(expression)
                           .ToListAsync();
        }

        public async Task<T> GetById(long id)
        {
            return await _table.FindAsync(id);
        }



        public async Task<T> Update(T entity)
        {
            if (_table.Entry(entity).State == EntityState.Detached)
                _table.Attach(entity);


            _table.Entry(entity).State = EntityState.Modified;
            return entity;
        }


        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }


    }
}
