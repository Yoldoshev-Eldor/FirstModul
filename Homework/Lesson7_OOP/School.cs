namespace Lesson7_OOP;

internal class School
{
    public static string Region {  get; set; }
    public static string District { get; set; }
    public static int SchoolNumber { get; set; }
    public static int BuildYear { get; set; }
    public static int NumberOfStudents { get; set; }
    public static int Floor { get; set; }
    public static int Rooms { get; set; }
    public static string Uniform {  get; set; }
    public static string Director {  get; set; }
    public static string Motto { get; set; }
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
