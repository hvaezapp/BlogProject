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
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("TblCategory");

            builder.HasKey(a=>a.Id);

            builder
                .Property(a => a.Title)
                .IsRequired();

           
         
        }
    }
}
