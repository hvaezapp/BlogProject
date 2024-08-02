using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Application.Dto.PostTag
{
    public class GetPostTagDto : CreatePostTagDto
    {
        public long Id { get; set; }
    }
}
