using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Configuration
{
    public class ExportDetail_Configuration : IEntityTypeConfiguration<ExportDetail>
    {
        public void Configure(EntityTypeBuilder<ExportDetail> builder)
        {
            builder.ToTable("ExportDetail");
            builder.HasKey(x => new { x.ProductId, x.ExportId });
            builder.Property(z => z.TotalPrice).IsRequired();
            builder.HasOne(z => z.Product).WithMany(c => c.ExportDetails)
                .HasForeignKey(z => z.ProductId);
            builder.HasOne(z => z.Export).WithMany(c => c.ExportDetails)
                .HasForeignKey(c => c.ExportId);
        }
    }
}
