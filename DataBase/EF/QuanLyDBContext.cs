using System;
using System.Collections.Generic;
using System.Text;
using DataBase.Configuration;
using DataBase.Entities;
/*using DataBase.Configuration;
using DataBase.Entities;*/
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataBase.EF
{
   public class QuanLyDBContext : IdentityDbContext<User, Role, Guid>
    {
        public QuanLyDBContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API
            modelBuilder.ApplyConfiguration(new Role_Configuration());
            modelBuilder.ApplyConfiguration(new ImportDetail_Configuration());
            modelBuilder.ApplyConfiguration(new ExportDetail_Configuration());
            modelBuilder.ApplyConfiguration(new Customer_Configuration());
            modelBuilder.ApplyConfiguration(new User_Configuration());
            modelBuilder.ApplyConfiguration(new Supplier_Configuration());
            modelBuilder.ApplyConfiguration(new Import_Configuration());
            modelBuilder.ApplyConfiguration(new Export_Configuration());
            modelBuilder.ApplyConfiguration(new Product_Configuration());
            modelBuilder.ApplyConfiguration(new ProductImage_Configuration());
            modelBuilder.ApplyConfiguration(new Category_Configuration());
            modelBuilder.ApplyConfiguration(new ProductInCategory_Configuration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("UserRole").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens").HasKey(x => x.UserId);

        }
        public DbSet<ImportDetail> ImportDetails { get; set; }
        public DbSet<ExportDetail> ExportDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Userss { get; set; }
        public DbSet<Import> Imports { get; set; }
        public DbSet<Export> Exports { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<ProductInCategory> ProductInCategorys { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Role> Roless { get; set; }
    }
}
