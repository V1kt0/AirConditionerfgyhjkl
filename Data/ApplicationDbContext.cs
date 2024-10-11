using ClimateControlWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace ClimateControlWebsite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet for Products
        public DbSet<Product> Products { get; set; }
    }
}
