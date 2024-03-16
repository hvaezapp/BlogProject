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
    public class PostEntityConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(a=>a.Id);

            builder
                .Property(a => a.Title)
                .IsRequired()
                .HasMaxLength(150);


            builder
                .Property(a => a.Summary)
                .IsRequired()
                .HasMaxLength(500);


            builder
                .Property(a => a.Desription)
                .IsRequired();


        }
    }
}
