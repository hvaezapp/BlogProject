using BlogProject.Domain.common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Domain.entity
{
    public class PostTag : BaseEntity
    {
        public string Name { get; set; }
        public long PostId { get; set; } 


        // relation

        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; }

    }
}
