namespace Lesson7_OOP;

internal class School
{
    public string Region { get; set; }
    public string District { get; set; }
    public int SchoolNumber { get; set; }
    public int BuildYear { get; set; }
    public int NumberOfStudents { get; set; }
    public int Floor { get; set; }
    public int Rooms { get; set; }
    public string Uniform { get; set; }
    public string Director { get; set; }
    public string Motto { get; set; }
    public void DisplayInfo()
    {
        Console.WriteLine($"Region :             {Region}");
        Console.WriteLine($"District :           {District}");
        Console.WriteLine($"School Number :      {SchoolNumber}");
        Console.WriteLine($"Build Year :         {BuildYear}");
        Console.WriteLine($"Number of students : {NumberOfStudents}");
        Console.WriteLine($"Director :           {Director}");
        Console.WriteLine($"Floor :              {Floor}");
        Console.WriteLine($"Rooms :              {Rooms}");
        Console.WriteLine($"Unifor :             {Uniform}");
        Console.WriteLine($"Motto :              {Motto}");
    }
}
