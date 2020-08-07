using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DbFirst.Models
{
    public partial class ecommerceContext : DbContext //IdentityDbContext<IdentityUser>
    {
        public ecommerceContext()
        {
        }

        public ecommerceContext(DbContextOptions<ecommerceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=ecommerce;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Author).HasMaxLength(50);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Genre).HasMaxLength(50);
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BookId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Comment)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Rating)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_Comments_Books");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Comments_Customers");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Address)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Card)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Discount)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RegistrationDate).HasColumnType("date");
            });

            modelBuilder.Entity<OrderItems>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BookId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BooksCount)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OrderId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_OrderItems_Books1");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderItems_Orders");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Orders_Customers");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
