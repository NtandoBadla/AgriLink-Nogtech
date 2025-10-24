using Microsoft.EntityFrameworkCore;
using AgriLink.Backend.Models;

namespace AgriLink.Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Product> Products { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);
}
}
        }
