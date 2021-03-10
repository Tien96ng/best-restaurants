using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public Restaurant()
    {
      this.Review = new List<Review> ();
    }

    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public int CuisineId { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
  }
}