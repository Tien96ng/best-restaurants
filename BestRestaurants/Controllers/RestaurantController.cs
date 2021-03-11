using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace BestRestaurants.Controllers
{
  public class RestaurantController : Controller
  {
    private readonly BestRestaurantsContext _db;
    
    public RestaurantController(BestRestaurantsContext db)
    {
      _db = db;
    }
    
    public ActionResult Index(int cuisineId)
    {
      List<Restaurant> model = _db.Restaurants.Where(restaurant => restaurant.CuisineId == cuisineId).ToList();
      return View(model);
    }

  }
}