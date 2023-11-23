using GasYa.Web.Api.Domain.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace GasYa.Web.Api.Infrastructure.Data.Context;

public class GasYaDbContext : DbContext
{
    public DbSet<ClientAggregate> Clients { get; set; }
    public DbSet<GasStationAggregate> GasStations { get; set; }
    public DbSet<InventoryAggregate> Inventories { get; set; }
    public DbSet<FuelAggregate> Fuels { get; set; }
    public DbSet<PromotionAggregate> Promotions { get; set; }
    
    public GasYaDbContext(DbContextOptions<GasYaDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClientAggregate>().HasKey(c => c.Id);
        modelBuilder.Entity<FuelAggregate>().HasKey(f => f.Id);
        modelBuilder.Entity<GasStationAggregate>().HasKey(g => g.Id);
        modelBuilder.Entity<InventoryAggregate>().HasKey(i => new { i.GasStationId, i.FuelId });
        modelBuilder.Entity<PromotionAggregate>().HasKey(p => p.Id);
    }
}