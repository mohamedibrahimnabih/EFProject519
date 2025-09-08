using EFProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EFProject.Data
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFProject519-2;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .Property(c=>c.Name)
                .HasColumnType("varchar(50)");

            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .HasMaxLength(60)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<ProductImage>()
                .HasKey(e => new { e.Img, e.ProductId });
        }
    }
}
