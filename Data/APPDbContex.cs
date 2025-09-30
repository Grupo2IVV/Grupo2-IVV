using Microsoft.EntityFrameworkCore;
using PrimerParcialProgra.Models; // Importa el Product.cs

namespace PrimerParcialProgra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}