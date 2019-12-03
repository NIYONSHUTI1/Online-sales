using Microsoft.EntityFrameworkCore;

namespace onlinesales.Data
{
    public class ProductsContext : DbContext
    {
        public ProductsContext (DbContextOptions<ProductsContext> options)
            : base(options)
        {
        }

        public DbSet<onlinesales.Models.Product> Products { get; set; }
    }
}
