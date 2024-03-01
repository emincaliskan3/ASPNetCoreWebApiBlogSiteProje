using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DatabaseContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(LocalDb)\MSSQLLocalDB; database=ASPNetCoreWebApiBlogSiteProje; integrated security=True; trustservercertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Email = "admin@mvckurumsal.net",
                IsActive = true,
                IsAdmin = true,
                Name = "Admin",
                Surname = "User",
                Password = "Admin123"
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
