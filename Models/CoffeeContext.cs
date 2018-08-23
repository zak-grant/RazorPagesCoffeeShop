using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Models
{
    public class CoffeeContext : DbContext
    {
        public CoffeeContext(DbContextOptions<CoffeeContext> options) : base(options)
        {

        }
        public DbSet<Coffee> Coffee { get; set; }
    }
}