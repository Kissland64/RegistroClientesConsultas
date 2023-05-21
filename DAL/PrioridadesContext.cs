using Microsoft.EntityFrameworkCore;

public class PrioridadesContext : DbContext
{
    public DbSet<Prioridades> Prioridades { get; set; }

    public PrioridadesContext(DbContextOptions<PrioridadesContext> options) : base(options)
    {
        
    }

}