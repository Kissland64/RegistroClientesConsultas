using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public DbSet<Clientes> Clientes { get; set; }
    public DbSet<Prioridades> Prioridades { get; set; }

    public Context(DbContextOptions<Context> options) : base(options)
    {}
}