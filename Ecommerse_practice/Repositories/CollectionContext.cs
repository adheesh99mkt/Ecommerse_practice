using Microsoft.EntityFrameworkCore;
using Ecommerse_practice.Models;

namespace Ecommerse_practice.Repositories
{
    public class CollectionContext : DbContext
    {
        public DbSet<Products> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String connectedString = "server=localhost;port=3306;username=root;password=root123;database=practice";
            optionsBuilder.UseMySQL(connectedString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Products>(Entity =>
            {
                Entity.HasKey(p => p.Id);
                Entity.Property(p=>p.Title).IsRequired();
                Entity.Property(p=> p.Description).IsRequired();
                Entity.Property(p=>p.UnitPrice).IsRequired();
                Entity.Property(p => p.ImageUrl);
                Entity.Property(p=>p.Quantity).IsRequired();
            });
            modelBuilder.Entity<Products>().ToTable("products");
        }
    }
}
