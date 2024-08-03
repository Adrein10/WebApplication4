using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication4.Models
{
    public partial class mydataContext : DbContext
    {
        public mydataContext()
        {
        }

        public mydataContext(DbContextOptions<mydataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Product");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Email)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
