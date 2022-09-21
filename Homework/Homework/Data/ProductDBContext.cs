using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Homework.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Homework.Data
{
    public partial class ProductDBContext : DbContext
    {
        public ProductDBContext()
        {
        }

        public ProductDBContext(DbContextOptions<ProductDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Service> Service { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProductDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.ServiceId)
                    .HasColumnName("ServiceID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ServiceDescription).IsUnicode(false);

                entity.Property(e => e.ServiceName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
