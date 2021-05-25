using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Configuration
{
    public class ImportDetail_Configuration : IEntityTypeConfiguration<ImportDetail>
    {
        public void Configure(EntityTypeBuilder<ImportDetail> builder)
        {
            builder.ToTable("ImportDetail");
            builder.HasKey(x => new { x.ProductId, x.ImportId });
            //  cấu hình n-n đấy
            builder.Property(z => z.TotalPrice).IsRequired();
            builder.HasOne(z => z.Import).WithMany(c => c.ImportDetails)
                .HasForeignKey(c => c.ImportId);
            builder.HasOne(z => z.Product).WithMany(c => c.ImportDetails)
                .HasForeignKey(c => c.ProductId);
        }
    }
}
