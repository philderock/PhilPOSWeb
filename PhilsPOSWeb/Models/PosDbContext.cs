using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PhilsPOSWeb.Models
{
    public class PosDbContext : IdentityDbContext
    {
        public PosDbContext(DbContextOptions<PosDbContext>options) : base(options)
        {

        }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
