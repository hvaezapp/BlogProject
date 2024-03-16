using BlogProject.Domain.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Persistence.Context
{
    public class BlogDB : DbContext
    {

        public BlogDB(DbContextOptions<BlogDB> options) : base(options)
        {
        
        }




        #region Tables

        public DbSet<Category> Category { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<PostComment> PostComment { get; set; }
        public DbSet<PostTag> PostTag { get; set; }
        public DbSet<User> User { get; set; }

        #endregion

    }
}
