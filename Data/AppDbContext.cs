using Microsoft.EntityFrameworkCore;
using Grupo2.Models; // <-- Ajusta el namespace según el tuyo

namespace Grupo2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<SupportTicket> SupportTickets { get; set; }
    }
}