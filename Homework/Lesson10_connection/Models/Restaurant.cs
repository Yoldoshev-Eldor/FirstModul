namespace Lesson10_connection.Models;

public class Restaurant
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public double Rating { get; set; }
    public Restaurant Dishes { get; set; }
}
