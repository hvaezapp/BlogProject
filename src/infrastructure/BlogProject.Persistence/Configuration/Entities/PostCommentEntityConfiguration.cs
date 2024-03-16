using BlogProject.Domain.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Persistence.Configuration.Entities
{
    public class PostCommentEntityConfiguration : IEntityTypeConfiguration<PostComment>
    {
        public void Configure(EntityTypeBuilder<PostComment> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .Property(a=>a.Description)
                .IsRequired()
                .HasMaxLength(300);
        }
    }
}
