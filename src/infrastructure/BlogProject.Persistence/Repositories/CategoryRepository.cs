﻿using BlogProject.Application.Contract.Persistence;
using BlogProject.Domain.entity;
using BlogProject.Persistence.Context;

namespace BlogProject.Persistence.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly BlogDB _context;
        public CategoryRepository(BlogDB context) : base(context)
        {
            _context = context;
        }

    }
}
