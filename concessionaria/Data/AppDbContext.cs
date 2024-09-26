using System;
using concessionaria.Models;
using Concessionaria.Models;
using Microsoft.EntityFrameworkCore;

namespace concessionaria.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

    }
    public DbSet<Car> Cars { get; set;}
    public DbSet<Brand> Brands { get; set;}
    public DbSet<Image> Images { get; set;}
    public DbSet<Employee> Employees { get; set;}
    public DbSet<AditionalFeature> AditionalFeatures { get; set;}
    public DbSet<Sale> Sales { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Car>()
        .HasOne(c => c.Sale)
        .WithOne(s => s.car)
        .HasForeignKey<Sale>(s => s.CarId); // Aqui estamos explicitamente definindo a chave estrangeira

    base.OnModelCreating(modelBuilder);
}

}
