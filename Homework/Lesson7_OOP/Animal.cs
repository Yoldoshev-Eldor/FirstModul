namespace Lesson7_OOP;

internal class Animal
{
    public string Name { get; set; }
    public string Meals { get; set; }
    public int Weight { get; set; }
    public string Habitat { get; set; }
    public int BornYear { get; set; }
    public string PopularTypes { get; set; }
    public string WhichFamily { get; set; }
    public string AverageLifeSpan { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name :              {Name}");
        Console.WriteLine($"Meals :             {Meals}");
        Console.WriteLine($"Weight :            {Weight}");
        Console.WriteLine($"Habitat :           {Habitat}");
        Console.WriteLine($"Born Years :        {BornYear}");
        Console.WriteLine($"Popular Types :     {PopularTypes}");
        Console.WriteLine($"Which Family :      {WhichFamily}");
        Console.WriteLine($"Average Life Span : {AverageLifeSpan}");
    }
    public void Age()
    {
        Console.WriteLine($"Age : {2024-BornYear}");
    }


}
