using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Configuration
{
    public class Category_Configuration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(x => x.CategoryId);
            builder.Property(x => x.CategoryId).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

        }
    }
}
