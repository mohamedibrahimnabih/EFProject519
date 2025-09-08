using SolveChallenge.Models;
using Microsoft.EntityFrameworkCore;

namespace SolveChallenge.Data
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeImage> EmployeeImages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SolveChallenge519-2;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .HasColumnType("varchar(100)");

            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeImage>()
                .HasKey(e => new { e.EmployeeId, e.Img });
        }
    }
}
