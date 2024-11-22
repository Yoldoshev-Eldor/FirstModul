using Lesson8_constructor.Models;
using Lesson8_constructor.Services;

namespace Lesson8_constructor
{
    internal class Program
    {

        static void Main(string[] args)
        {
            StartFrontend();
        }
        public static void StartFrontend()
        {
            var carService = new CarService();
            while (true)
            {
                Console.WriteLine(" 1. Add car : ");
                Console.WriteLine(" 2. Update car : ");
                Console.WriteLine(" 3. Delete car : ");
                Console.WriteLine(" 4. Get all car : ");
                Console.Write("Choose : ");
                var option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    var car = new Car();
                    Console.Write("Enter name : ");
                    car.Name = Console.ReadLine();
                    Console.Write("Enter colour : ");
                    car.Colour = Console.ReadLine();
                    Console.Write("Enter Distance traveled : ");
                    car.DistanceTraveled = int.Parse(Console.ReadLine());
                    Console.Write("Enter Speed : ");
                    car.Speed = int.Parse(Console.ReadLine());
                    Console.Write("Enter Weight : ");
                    car.Weight = int.Parse(Console.ReadLine());
                    Console.Write("Enter Factory : ");
                    car.Factory = Console.ReadLine();
                    car.DateTime = DateTime.Now;
                    carService.AddCar(car);
                    Console.WriteLine("Succsesfull . . . ");



                }
                else if (option == 2)
                {
                    var car = new Car();
                    Console.WriteLine("Enter update car ID : ");
                    car.Id = Guid.Parse(Console.ReadLine());
                    Console.Write("Enter name : ");
                    car.Name = Console.ReadLine();
                    Console.Write("Enter colour : ");
                    car.Colour = Console.ReadLine();
                    Console.Write("Enter Distance traveled : ");
                    car.DistanceTraveled = int.Parse(Console.ReadLine());
                    Console.Write("Enter Speed : ");
                    car.Speed = int.Parse(Console.ReadLine());
                    Console.Write("Enter Weight : ");
                    car.Weight = int.Parse(Console.ReadLine());
                    Console.Write("Enter Factory : ");
                    car.Factory = Console.ReadLine();
                    car.DateTime = DateTime.Now;
                    var result = carService.UpdateCar(car);
                    if (result)
                    {
                        Console.WriteLine("Updateded . . .");
                    }
                    else
                    {
                        Console.WriteLine(" Error ---> no updateded Sorry . . . ");
                    }

                }
                else if (option == 3)
                {
                    Console.WriteLine("Enter delete Id : ");
                    var id = Guid.Parse(Console.ReadLine());
                    var result = carService.DeleteCar(id);
                    if (result)
                    {
                        Console.WriteLine("Delete succesfull");
                    }
                    else
                    {
                        Console.WriteLine("Error . . . ");
                    }

                }
                else if (option == 4)
                {
                    var cars = carService.GetAllCars();
                    for (var i = 0; i < cars.Count; i++)
                    {
                        Console.WriteLine($"Id :       {cars[i].Id}");
                        Console.WriteLine($"Name :     {cars[i].Name}");
                        Console.WriteLine($"colour :   {cars[i].Colour}");
                        Console.WriteLine($"Speed :    {cars[i].Speed}");
                        Console.WriteLine($"Distance : {cars[i].DistanceTraveled}");
                        Console.WriteLine($"Weight :   {cars[i].Weight}");
                        Console.WriteLine($"Factory :  {cars[i].Factory}");
                        Console.WriteLine($"Date Time: {cars[i].DateTime}");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
