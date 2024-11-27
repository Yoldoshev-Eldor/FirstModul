namespace Lesson10_connection.Models;

public class Dish
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public Dish RestaurantId { get; set; }
}
