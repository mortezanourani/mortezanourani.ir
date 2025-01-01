using Microsoft.EntityFrameworkCore;
using mortezanourani.ir.Models;

namespace mortezanourani.ir.Data;

#nullable disable
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Album> Albums { get; set; }

    public DbSet<Image> Images { get; set; }
}
