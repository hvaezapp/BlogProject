using BlogProject.Application.Contract.Persistence;
using BlogProject.Domain.entity;
using BlogProject.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Persistence.Repositories
{
    public class PostCommentRepository : Repository<PostComment> , IPostCommentRepository
    {
        private readonly BlogDB _context;
        public PostCommentRepository(BlogDB context) : base(context)
        {
            _context = context;
        }

        //...............
    }
}
