using PruebaTecnica.Models;
using Microsoft.EntityFrameworkCore;

namespace PruebaTecnica.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
