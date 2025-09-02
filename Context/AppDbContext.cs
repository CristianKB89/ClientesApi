using PruebaTecnica.Models;
using Microsoft.EntityFrameworkCore;

namespace PruebaTecnica.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options), DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}
