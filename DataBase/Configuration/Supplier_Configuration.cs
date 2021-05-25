using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Configuration
{
    public class Supplier_Configuration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("Supplier");
            builder.HasKey(z => z.SupplierId);
            builder.Property(z => z.Name).IsRequired().HasMaxLength(200);
        }
    }
}
