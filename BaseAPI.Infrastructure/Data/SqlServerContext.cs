using Microsoft.EntityFrameworkCore;
using BaseAPI.Domain.Entities;
using System.Reflection;

namespace BaseAPI.Infrastructure.Data
{
  public class SqlServerContext : DbContext
  {
    public SqlServerContext() { }

    public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options) { }

    public DbSet<Costumer> Clients { get; set; }
    public DbSet<Product> Products { get; set; }

    public override int SaveChanges()
    {
      foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreatedAt") != null))
      {
        if (entry.State == EntityState.Added)
        {
          entry.Property("CreatedAt").CurrentValue = DateTime.Now;
        }

        if (entry.State == EntityState.Modified)
        {
          entry.Property("CreatedAt").IsModified = false;
        }
      }
      return base.SaveChanges();
    }
  }
}
