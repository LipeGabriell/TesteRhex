using Microsoft.EntityFrameworkCore;
using TesteRhex.Data;

namespace TesteRhex.Contexts;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    DbSet<Tool> Tools { get; set; }
}