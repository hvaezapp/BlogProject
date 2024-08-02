using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Application.Dto.PostTag
{
    public class CreatePostTagDto
    {
        public string Name { get; set; }
        public long PostId { get; set; }
    }
}
