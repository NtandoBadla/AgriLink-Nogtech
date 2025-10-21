using AgriLink.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgriLink.Infrastructure
{
    public class AgriLinkDbContext : DbContext
    {
        public AgriLinkDbContext(DbContextOptions<AgriLinkDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Farm> Farms => Set<Farm>();
        //public DbSet<Listing> Listings => Set<Listing>();
        public DbSet<Driver> Drivers => Set<Driver>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Fluent configuration here
        }
    }
}
