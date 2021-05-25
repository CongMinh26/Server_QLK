using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Configuration
{
    public class Import_Configuration : IEntityTypeConfiguration<Import>
    {
        public void Configure(EntityTypeBuilder<Import> builder)
        {
            builder.ToTable("Import");
            builder.HasKey(z => z.ImportId);
            builder.Property(z => z.ImportId).UseIdentityColumn();
            builder.Property(z => z.UserId).IsRequired();
            builder.Property(z => z.Status).IsRequired();
            builder.Property(z => z.SupplierId).IsRequired();

            builder.HasOne(z => z.Supplier).WithMany(c => c.Imports)
                .HasForeignKey(z => z.SupplierId);

            builder.HasOne(z => z.User).WithMany(c => c.Imports)
                .HasForeignKey(z => z.UserId);
        }
    }
}
