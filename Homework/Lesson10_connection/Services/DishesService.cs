using Lesson10_connection.Models;

namespace Lesson10_connection.Services;

public class DishesService
{
    private List<Dish> dishes;
    public DishesService()
    {
        dishes = new List<Dish>();
    }
    public Dish AddDish(Dish dish)
    {
        dish.Id = Guid.NewGuid();
        dishes.Add(dish);
        return dish;
    }
    public Dish GetById(Guid id)
    {
        foreach (var dish in dishes)
        {
            if (dish.Id == id)
            {
                return dish;
            }
        }

        return null;
    }
    public bool UpdateDish(Dish dish)
    {
        var excist =GetById(dish.Id);
        if (excist == null)
        {
            return false;
        }
        var index = dishes.IndexOf(dish);
        dishes[index] = dish;
        return true;
    }
    public bool DeleteDish(Guid id)
    {
        var excist = GetById(id);
        if (excist == null)
        {
            return false;
        }
        dishes.Remove(excist);
        return true;
    }
    public List<Dish> GetAll()
    {
        return dishes;
    }

}
