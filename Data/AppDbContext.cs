using Microsoft.EntityFrameworkCore;
using PrimerParcialProgra.Models;

namespace PrimerParcialProgra.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Event> Events => Set<Event>();
}