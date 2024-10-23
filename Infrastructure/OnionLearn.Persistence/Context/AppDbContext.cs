using System.Net.Mime;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using OnionLearn.Domain.Entities;

namespace Persistence.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(){}
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    
    
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Detail> Details { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(p => p.Discount)
                .HasColumnType("decimal(18, 2)") // 18 basamak, 2 ondalık
                .HasPrecision(18, 2); // Hassasiyet ve ölçek belirleme

            entity.Property(p => p.Price)
                .HasColumnType("decimal(18, 2)") // 18 basamak, 2 ondalık
                .HasPrecision(18, 2); // Hassasiyet ve ölçek belirleme
        });
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}