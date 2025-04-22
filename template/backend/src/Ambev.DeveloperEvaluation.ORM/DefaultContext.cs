using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM;

public class DefaultContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Sales> Sales { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure composite primary key
        modelBuilder.Entity<SaleItem>()
            .HasKey(si => new { si.SalesId, si.ProductId });


        // Sales relationship
        modelBuilder.Entity<Sales>()
            .HasMany(s => s.Items)
            .WithOne()
            .HasForeignKey(si => si.SalesId)
            .OnDelete(DeleteBehavior.Cascade);

    }

}