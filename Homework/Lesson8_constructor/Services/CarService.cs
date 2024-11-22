using Lesson8_constructor.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_constructor.Services;

public class CarService
{
    private List<Car> cars;
    public CarService() 
    {
        cars = new List<Car>();
        DataSeed();
    }
    public Car AddCar(Car addingCar)
    {
        addingCar.Id = Guid.NewGuid();
        cars.Add(addingCar);
        return addingCar;
    }
    public bool DeleteCar(Guid carId)
    {
        bool exists = false;
        foreach (var car in cars)
        {
            if (car.Id == carId)
            {
                cars.Remove(car);
                exists = true;
                break;
            }
        }
        return exists;
    }
    public bool UpdateCar (Car updateCar)
    {
        bool exists = false;
        for ( var i = 0; i < cars.Count; i++ )
        {
            if (cars[i].Id == updateCar.Id)
            {
                cars[i]= updateCar;
                exists = true;
                break;
            }
        }
        return exists;
    }
    public List<Car> GetAllCars()
    {
        return cars;
    }
    private void DataSeed()
    {
        var car1 = new Car();
        {
            car1.Id = Guid.NewGuid();
            car1.Name = "Nexia";
            car1.Colour = "White";
            car1.Speed = 200;
            car1.DistanceTraveled = 0;
            car1.Weight = 1700;
            car1.Factory = "GM";
            car1.DateTime = DateTime.Now;

        }
        var car2 = new Car();
        {
            car2.Id = Guid.NewGuid();
            car2.Name = "Damas";
            car2.Colour = "Blue";
            car2.Speed = 140;
            car2.DistanceTraveled = 1;
            car2.Weight = 1400;
            car2.Factory = "Daewoo";
            car2.DateTime = DateTime.Now;
        }
        var car3 = new Car();
        {
            car3.Id = Guid.NewGuid();
            car3.Name = "Damas";
            car3.Colour = "Blue";
            car3.Speed = 140;
            car3.DistanceTraveled = 1;
            car3.Weight = 1400;
            car3.Factory = "GM";
            car3.DateTime = DateTime.Now;
        }
        cars.Add(car1);
        cars.Add(car2);
        cars.Add(car3);


    }
}
