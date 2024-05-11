using Labb4Book.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Labb4Book.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<CustomerBook> CustomerBooks { get; set; }

    }
}
