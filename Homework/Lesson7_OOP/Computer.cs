namespace Lesson7_OOP;

internal class Computer
{
    public string Model { get; set; }
    public string Display { get; set; }
    public int Ram { get; set; }
    public int Rom { get; set; }
    public string Cpu { get; set; }
    public int YearOfIssue { get; set; }
    public string PeriodOfUse { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Model :           {Model}");
        Console.WriteLine($"Display :         {Display}");
        Console.WriteLine($"Ram :             {Ram}");
        Console.WriteLine($"Rom  :            {Rom}");
        Console.WriteLine($"Cpu :             {Cpu}");
        Console.WriteLine($"Year of issue :   {YearOfIssue}");
        Console.WriteLine($"Period of use :   {PeriodOfUse}");
    }
}
