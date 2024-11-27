using Lesson10_connection.Models;

namespace Lesson10_connection.Services;

public class RestaurantService
{
    private List<Restaurant> restaurants;
    public RestaurantService()
    {
        restaurants = new List<Restaurant>();
    }
    public Restaurant AddRestaurnat(Restaurant restaurant)
    {
        restaurant.Id = Guid.NewGuid();
        restaurants.Add(restaurant);
        return restaurant;
    }
    public Restaurant GetById(Guid id)
    {
        foreach (var restaurant in restaurants)
        {
            if (restaurant.Id == id)
            {
                return restaurant;
            }
        }
        return null;
    }
    public bool DeleteRestaurnat(Guid id)
    {
        var excist = GetById(id);
        if (excist == null)
        {
            return false;
        }
        restaurants.Remove(excist);
        return true;
    }
    public bool UpdateRestaurant(Restaurant restaurant)
    {
        var restauranatDb = GetById(restaurant.Id);
        if (restauranatDb == null)
        {
            return false;
        }
        var index = restaurants.IndexOf(restaurant);
        restaurants[index] = restaurant;
        return true;
    }
    public List<Restaurant> GetAll()
    {
        return restaurants;
    }
    public Restaurant GetTopRatedRestaurant()
    {
        var ratingRestaurant = new Restaurant();
        foreach (var restaurant in restaurants)
        {
            if (restaurant.Rating > ratingRestaurant.Rating)
            {
                ratingRestaurant = restaurant;
            }
        }
        return ratingRestaurant;
    }
}
