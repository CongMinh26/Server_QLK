using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Configuration
{
    public class User_Configuration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(z => z.UserId);
            builder.Property(z => z.FullName).IsRequired().HasMaxLength(200);
            builder.Property(z => z.Password).IsRequired().HasMaxLength(200);
        }
    }
}
