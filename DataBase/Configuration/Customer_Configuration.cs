using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Configuration
{
    public class Customer_Configuration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(z => z.CustomerId);
            builder.Property(z => z.FullName).IsRequired().HasMaxLength(200);
            builder.Property(z => z.Email).IsRequired().HasMaxLength(200);
        }
    }
}
