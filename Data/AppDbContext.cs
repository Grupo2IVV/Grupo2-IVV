using Microsoft.EntityFrameworkCore;
using PrimerParcialProgra.Models;   // <- usar Models

namespace PrimerParcialProgra.Data   // <- corregir namespace
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<SupportTicket> SupportTickets { get; set; }
    }
}