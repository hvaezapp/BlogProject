using BlogProject.Domain.common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Domain.entity
{
    public class Post : BaseEntity
    {
        public long CategoryId { get; set; }
        public string Title { get;set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int ViewCount { get; set; }



        // relation

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }


        public Post()
        {
           ViewCount = 0;
        }
    }
}
