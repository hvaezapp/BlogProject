using BlogProject.Domain.entity;
using Microsoft.EntityFrameworkCore;

namespace BlogProject.Persistence.Context
{
    public class BlogDB : DbContext
    {

        public BlogDB(DbContextOptions<BlogDB> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Add Entities Configuration to migration

            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(BlogDB).Assembly);


            base.OnModelCreating(modelBuilder);
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
