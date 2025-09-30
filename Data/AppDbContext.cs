using Microsoft.EntityFrameworkCore;
 SupportTicket
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

using PrimerParcialProgra.Models;

namespace PrimerParcialProgra.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Event> Events => Set<Event>();
 main
}