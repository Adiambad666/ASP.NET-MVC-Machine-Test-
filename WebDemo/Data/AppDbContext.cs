using Microsoft.EntityFrameworkCore;
using WebDemo.Models;

namespace WebDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Products> products { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
