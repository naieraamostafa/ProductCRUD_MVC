using Microsoft.EntityFrameworkCore;

namespace Product_Management.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> ProductStores { get; set; }
    }
}
