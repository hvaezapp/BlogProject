using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Application.Dto.Post
{
    public class PostDto
    {
        public long CategoryId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Desription { get; set; }
        public string ImageUrl { get; set; }
        public int ViewCount { get; set; }
    }
}
