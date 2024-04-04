using BlogProject.Domain.common;
using System.ComponentModel.DataAnnotations.Schema;

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
