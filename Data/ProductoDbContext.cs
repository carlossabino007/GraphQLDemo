using Microsoft.EntityFrameworkCore;
using GraphQLDemo.Models;

namespace GraphQLDemo.Data
{
    public class ProductoDbContext : DbContext
    {
        public ProductoDbContext(DbContextOptions<ProductoDbContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
    }
}