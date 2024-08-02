using BlogProject.Application.Contract.Persistence;
using BlogProject.Persistence.Context;
using BlogProject.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Persistence.Configuration.Repositories
{
    public static class ConfigureRepositories
    {
        public static void ConfigureAppRepositories(this IServiceCollection services)
        {

            // Configure Repositories

            services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IPostTagRepository, PostTagRepository>();

        }
    }
}
