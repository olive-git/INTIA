using Microsoft.EntityFrameworkCore;
using INTIA.Models;

namespace INTIA
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		public DbSet<Customer> Customers { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Firstname = "Alice", Lastname = "Johnson" },
                new Customer { Id = 2, Firstname = "Bob", Lastname = "Smith" },
                new Customer { Id = 3, Firstname = "Charlie", Lastname = "Brown" },
                new Customer { Id = 4, Firstname = "Diana", Lastname = "Prince" },
                new Customer { Id = 5, Firstname = "Ethan", Lastname = "Hunt" }
            );
        }

    }
}
