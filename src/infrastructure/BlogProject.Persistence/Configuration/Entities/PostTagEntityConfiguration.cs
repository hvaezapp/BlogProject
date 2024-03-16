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
    public class PostTagEntityConfiguration : IEntityTypeConfiguration<PostTag>
    {
        public void Configure(EntityTypeBuilder<PostTag> builder)
        {
            builder.ToTable("TblPostTag");

            builder.HasKey(a=>a.Id);

            builder
                .Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
