

using Microsoft.EntityFrameworkCore;
using TesteRhex.Data;

namespace TesteRhex.Contexts;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Tool> Tools { get; set; }
}