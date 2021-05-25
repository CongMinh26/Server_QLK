using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Configuration
{
    public class ProductInCategory_Configuration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategory");
            builder.HasKey(x => new { x.CategoryId ,x.ProductId});

            builder.HasOne(x => x.Product).WithMany(x => x.ProductInCategories)
                .HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Category).WithMany(x => x.ProductInCategories)
                .HasForeignKey(x => x.CategoryId);

        }
    }
}
