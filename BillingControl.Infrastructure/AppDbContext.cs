using BillingControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BillingControl.Infrastructure;

public sealed class AppDbContext : DbContext
{
    public DbSet<AccountReceive> ContasAReceber { get; set; }
    public DbSet<BillsToPay> ContasAPagar { get; set; }
    public DbSet<Customers> Clientes { get; set; }
    public DbSet<Servers> Servidores { get; set; }

    public AppDbContext() {}
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source= BillingControl.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
