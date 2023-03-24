using Microsoft.EntityFrameworkCore;

namespace Exercise03.Models
{
    public class BeerDbContext : DbContext
    {
        public DbSet<Beer> Beers { get; set; }
        public DbSet<BeerStyle> BeersStyle { get; set; }

        public BeerDbContext(DbContextOptions<BeerDbContext> options) : base(options)
        {

        }
    }
}
