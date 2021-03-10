using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public Cuisine()
    {
      this.Restaurants = new List<Restaurant> ();
    }

    public int CuisineId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }
  }
}