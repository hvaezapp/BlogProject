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
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);


            builder
                .Property(a => a.Firstname)
                .IsRequired()
                .HasMaxLength(100);



            builder
               .Property(a => a.Lastname)
               .IsRequired()
               .HasMaxLength(100);



            builder
             .Property(a => a.Username)
             .IsRequired()
             .HasMaxLength(50);



            builder
             .Property(a => a.Password)
             .IsRequired()
             .HasMaxLength(20);


        }
    }
}
