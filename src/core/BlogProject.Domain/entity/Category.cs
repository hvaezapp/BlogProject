using BlogProject.Domain.common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Domain.entity
{
    public class Category : BaseEntity
    { 
        public string Title { get; set; }
    }

}
