using BlogProject.Domain.common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Domain.entity
{
    public class PostComment : BaseEntity
    {
        public string Description { get; set; }
        public long PostId { get; set; } 
        public long UserId { get; set; }


        // relation

        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; }



        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
