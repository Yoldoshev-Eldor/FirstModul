using Lesson10_connection.Models;
using Lesson10_connection.Services;

namespace Lesson10_connection
{
    public class Program
    {
        static void Main(string[] args)
        {
            StartBookFrontEnd();
        }
        public static void StartBookFrontEnd()
        {
            var bookService = new BookService();
            while (true)
            {
                Console.WriteLine("1.Add Book : ");
                Console.WriteLine("2.Update Book : ");
                Console.WriteLine("3.Delete Book :");
                Console.WriteLine("4. Get All Books : ");
                Console.WriteLine("5.GetExpensiveBook : ");
                Console.WriteLine("6.GetMostPagedBook : ");
                Console.WriteLine("7.GetMostReadBook : ");
                Console.WriteLine("8.GetBooksByReaderName : ");
                Console.WriteLine("9.GetBooksByAuthorName : ");
                Console.WriteLine("10.AddReaderToBook : ");
                Console.WriteLine("11.AddAuthorToBook : ");
                Console.Write("Choose :  ");
                var option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    var book = new Book();
                    Console.Write("Enter Title : ");
                    book.Title = Console.ReadLine();
                    book.PublicationDate = DateTime.Now;
                    Console.Write("Enter Description : ");
                    book.Description = Console.ReadLine();
                    Console.Write("Enter Page Number : ");
                    book.PageNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter Price : ");
                    book.Price = double.Parse(Console.ReadLine());
                    Console.Write("Enter Author names count : ");
                    var countAuthorsName = int.Parse(Console.ReadLine());
                    for (var i = 0; i < countAuthorsName; ++i)
                    {
                        Console.Write($"Enter {i + 1} - Name : ");
                        var name = Console.ReadLine();
                        book.AuthorsName.Add(name);
                    }
                    Console.Write("Enter Reader names count : ");
                    var countReadersName = int.Parse(Console.ReadLine());
                    for (var i = 0; i < countReadersName; ++i)
                    {
                        Console.Write($"Enter {i + 1} - Name : ");
                        var name = Console.ReadLine();
                        book.ReadersName.Add(name);
                    }
                    bookService.AddBook(book);
                    Console.Write("Book Added . . . ");

                }
                else if (option == 2)
                {
                    var book = new Book();
                    Console.Write("Enter Id : ");
                    book.Id = Guid.Parse(Console.ReadLine());
                    Console.Write("Enter Title : ");
                    book.Title = Console.ReadLine();
                    book.PublicationDate = DateTime.Now;
                    Console.Write("Enter Description : ");
                    book.Description = Console.ReadLine();
                    Console.Write("Enter Page Number : ");
                    book.PageNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter Price : ");
                    book.Price = double.Parse(Console.ReadLine());
                    Console.Write("Enter Author names count : ");
                    var countAuthorsName = int.Parse(Console.ReadLine());
                    for (var i = 0; i < countAuthorsName; ++i)
                    {
                        Console.Write($"Enter {i + 1} - Name : ");
                        var name = Console.ReadLine();
                        book.AuthorsName.Add(name);
                    }
                    Console.Write("Enter Reader names count : ");
                    var countReadersName = int.Parse(Console.ReadLine());
                    for (var i = 0; i < countReadersName; ++i)
                    {
                        Console.Write($"Enter {i + 1} - Name : ");
                        var name = Console.ReadLine();
                        book.ReadersName.Add(name);
                    }
                    var updateBook = bookService.UpdateBook(book);
                    if (updateBook is true)
                    {
                        Console.WriteLine("succesfully . . . ");
                    }
                    else
                    {
                        Console.WriteLine("Error . . . ");
                    }
                }
                else if (option == 3)
                {
                    Console.Write("Enter Id : ");
                    var id = Guid.Parse(Console.ReadLine());
                    var result = bookService.DeleteBook(id);
                    if (result is true)
                    {
                        Console.WriteLine("Deleted . . . ");
                    }
                    else
                    {
                        Console.WriteLine("Error . . . ");
                    }
                }
                else if (option == 4)
                {
                    var books = bookService.GetAllBooks();
                    foreach (var book in books)
                    {
                        Console.WriteLine($"ID :          {book.Id}");
                        Console.WriteLine($"Title :       {book.Title}");
                        Console.WriteLine($"Page Number : {book.PageNumber}");
                        Console.WriteLine($"Price :       {book.Price}");
                        Console.WriteLine($"Discription : {book.Description}");
                        Console.Write("Book Authors : ");
                        foreach (var authorName in book.AuthorsName)
                        {
                            Console.Write($"{authorName} , ");
                        }
                    }
                }
                else if (option == 5)
                {
                    var book = bookService.GetExpensiveBook();
                    Console.WriteLine($"ID :          {book.Id}");
                    Console.WriteLine($"Title :       {book.Title}");
                    Console.WriteLine($"Page Number : {book.PageNumber}");
                    Console.WriteLine($"Price :       {book.Price}");
                    Console.WriteLine($"Discription : {book.Description}");
                    Console.Write($"Book Date time    {book.PublicationDate}");
                    Console.Write("Book Authors : ");
                    foreach (var authorName in book.AuthorsName)
                    {
                        Console.Write($"{authorName} , ");
                    }
                }
                else if (option == 6)
                {
                    var book = bookService.GetMostPagedBook();
                    Console.WriteLine($"ID :          {book.Id}");
                    Console.WriteLine($"Title :       {book.Title}");
                    Console.WriteLine($"Page Number : {book.PageNumber}");
                    Console.WriteLine($"Price :       {book.Price}");
                    Console.WriteLine($"Discription : {book.Description}");
                    Console.Write($"Book Date time    {book.PublicationDate}");
                    Console.Write("Book Authors : ");
                    foreach (var authorName in book.AuthorsName)
                    {
                        Console.Write($"{authorName} , ");
                    }
                }
                else if (option == 7)
                {
                    var book = bookService.GetMostReadBook();
                    Console.WriteLine($"ID :          {book.Id}");
                    Console.WriteLine($"Title :       {book.Title}");
                    Console.WriteLine($"Page Number : {book.PageNumber}");
                    Console.WriteLine($"Price :       {book.Price}");
                    Console.WriteLine($"Discription : {book.Description}");
                    Console.Write($"Book Date time    {book.PublicationDate}");
                    Console.Write("Book Authors : ");
                    foreach (var authorName in book.AuthorsName)
                    {
                        Console.Write($"{authorName} , ");
                    }
                }
                else if (option == 8)
                {
                    Console.Write("Enter Reader Name : ");
                    var name = Console.ReadLine();
                    var books = bookService.GetBooksByReaderName(name);
                    foreach (var book in books)
                    {
                        Console.WriteLine($"ID :          {book.Id}");
                        Console.WriteLine($"Title :       {book.Title}");
                        Console.WriteLine($"Page Number : {book.PageNumber}");
                        Console.WriteLine($"Discription : {book.Description}");
                        Console.Write("Book Authors : ");
                        foreach (var authorName in book.AuthorsName)
                        {
                            Console.Write($"{authorName} , ");
                        }
                    }

                }
                else if (option == 9)
                {
                    Console.Write("Enter Author Name : ");
                    var name = Console.ReadLine();
                    var books = bookService.GetBooksByAuthorName(name);
                    foreach (var book in books)
                    {
                        Console.WriteLine($"ID :          {book.Id}");
                        Console.WriteLine($"Title :       {book.Title}");
                        Console.WriteLine($"Page Number : {book.PageNumber}");
                        Console.WriteLine($"Discription : {book.Description}");
                        Console.Write("Book Authors : ");
                        foreach (var authorName in book.AuthorsName)
                        {
                            Console.Write($"{authorName} , ");
                        }
                    }
                }
                else if (option == 10)
                {
                    Console.Write("Enter Id : ");
                    var id = Guid.Parse(Console.ReadLine());
                    Console.Write("Enter name : ");
                    var name = Console.ReadLine();
                    var result = bookService.AddReaderToBook(id,name);
                    if (result is true)
                    {
                        Console.WriteLine("Name Added . . . ");
                    }
                    else
                    {
                        Console.WriteLine("Eror . . . ");
                    }
                }
                else if (option == 11)
                {
                    Console.Write("Enter Id : ");
                    var id = Guid.Parse(Console.ReadLine());
                    Console.Write("Enter name : ");
                    var name = Console.ReadLine();
                    var result = bookService.AddAuthorToBook(id, name);
                    if (result is true)
                    {
                        Console.WriteLine("Name Added . . . ");
                    }
                    else
                    {
                        Console.WriteLine("Eror . . . ");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void StartRestaurantFrontEnd()
        {

        }
        public void StartDishFrontEnd()
        {

        }
    }
}
