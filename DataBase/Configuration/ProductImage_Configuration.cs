
using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
namespace DataBase.Configuration
{
    public class ProductImage_Configuration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImage");
            builder.HasKey(x => x.ProductImageId);
            builder.Property(x => x.ProductImageId).UseIdentityColumn();
            builder.Property(x => x.PathImage).IsRequired();
            builder.HasOne(x => x.Product).WithMany(x => x.productImages).HasForeignKey(z => z.ProductId);
        }
    }
}
