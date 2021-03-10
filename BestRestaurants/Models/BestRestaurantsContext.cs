using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Models
{
  public class BestRestaurants : DbContext
  {
    public virtual DbSet<Cuisine> Cuisines { get; set; }
    public virtual DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Review> Reviews { get; set; }

    public BestRestaurantsContext(DbContext options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}