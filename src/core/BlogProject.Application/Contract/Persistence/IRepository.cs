﻿using BlogProject.Infrastructure.Enums;
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

        Task<T> Create(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<T> FirstOrDefualt(Expression<Func<T, bool>> expression, params Joins[] joins);
        Task<IEnumerable<T>> GetAll(params Joins[] joins);
        Task<IEnumerable<T>> GetAll(Expression<Func<T,bool>> expression);
        Task<T> Update(T entity);
        Task Delete(T entity);
        Task DeleteById(long id);
        Task<T> GetById(long id);
        Task<int> SaveAsync();

    }
}
