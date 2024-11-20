namespace Lesson7_OOP;

internal class Book
{
    public string Name { get; set; }    
    public int NumberOfPages { get; set; }
    public string Genre { get; set; }
    public string Author { get; set; }
    public string AuthorStyle { get; set; }
    public int YearOfWriting { get; set; }
    public string Meaning { get; set; }
    public string Popularity { get; set; }
    public string BookLanguage { get; set; }
    public string Conclusion { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Book Name:       {Name}");
        Console.WriteLine($"Book Page:       {NumberOfPages}");
        Console.WriteLine($"Book Genre:      {Genre}");
        Console.WriteLine($"Book Author:     {Author}");
        Console.WriteLine($"Author style:    {AuthorStyle}");
        Console.WriteLine($"Year of writing: {YearOfWriting}");
        Console.WriteLine($"Book Meaning:    {Meaning}");
        Console.WriteLine($"Book Popularity: {Popularity}");
        Console.WriteLine($"Book Language:   {BookLanguage}");
        Console.WriteLine($"Book Conclusion: {Conclusion}");
    }




}
