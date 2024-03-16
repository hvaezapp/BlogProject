using BlogProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Persistence.Configuration.Common
{
    public static class ConfigureService
    {
        public static void ConfigureServices(this IServiceCollection services , 
            IConfiguration configuration)
        {

            services.AddDbContext<BlogDB>(s =>
            {
                s.UseSqlServer(configuration.GetConnectionString("SqlSever"));
            });


            //..........

        }
    }
}
