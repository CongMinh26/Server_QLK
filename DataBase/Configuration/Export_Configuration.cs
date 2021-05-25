using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Configuration
{
    public class Export_Configuration : IEntityTypeConfiguration<Export>
    {
        public void Configure(EntityTypeBuilder<Export> builder)
        {
            builder.ToTable("Export");
            builder.HasKey(z => z.ExportId);
            builder.Property(z => z.ExportId).UseIdentityColumn();
            builder.Property(z => z.UserId).IsRequired();
            builder.Property(z => z.CustomerId).IsRequired();
            builder.Property(z => z.Status).IsRequired();
            builder.HasOne(z => z.Customer).WithMany(c => c.Exports)
                .HasForeignKey(z => z.CustomerId);
            builder.HasOne(z => z.User).WithMany(c => c.Exports)
                .HasForeignKey(z => z.UserId);

        }
    }
}
