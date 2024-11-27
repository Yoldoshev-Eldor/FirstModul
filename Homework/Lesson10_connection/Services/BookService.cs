using Lesson10_connection.Models;

namespace Lesson10_connection.Services;

public class BookService
{
    private List<Book> books;
    public BookService()
    {
        books = new List<Book>();
    }
    public Book AddBook(Book book)
    {
        book.Id = Guid.NewGuid();
        books.Add(book);
        return book;
    }
    public Book GetById(Guid id)
    {
        foreach (var book in books)
        {
            if (book.Id == id)
            {
                return book;
            }
        }
        return null;
    }
    public bool DeleteBook(Guid id)
    {
        var bookFromDb = GetById(id);
        if (bookFromDb == null)
        {
            return false;
        }
        books.Remove(bookFromDb);
        return true;
    }
    public bool UpdateBook(Book book)
    {
        var bookFromDb = GetById(book.Id);
        if (bookFromDb == null)
        {
            return false;
        }
        var index = books.IndexOf(book);
        books[index] = book;
        return true;
    }
    public List<Book> GetAllBooks()
    {
        return books;
    }
    public Book GetExpensiveBook()
    {
        var expensiveBook = new Book();
        foreach (var book in books)
        {
            if (expensiveBook.Price < book.Price)
            {
                expensiveBook = book;
            }
        }
        return expensiveBook;
    }
    public Book GetMostPagedBook()
    {
        var getMostPageBook = new Book();
        foreach (var book in books)
        {
            if (getMostPageBook.PageNumber < book.PageNumber)
            {
                getMostPageBook = book;
            }
        }
        return getMostPageBook;
    }
    public Book GetMostReadBook()
    {
        var getMostReadBook = new Book();
        foreach (var book in books)
        {
            if (book.ReadersName.Count > getMostReadBook.ReadersName.Count)
            {
                getMostReadBook = book;
            }
        }
        return getMostReadBook;
    }
    public List<Book> GetBooksByReaderName(string readerName)
    {
        var booksFromDb = new List<Book>();
        foreach (var book in books)
        {
            if (book.ReadersName.Contains(readerName))
            {
                booksFromDb.Add(book);
            }
        }
        return booksFromDb;
    }
    public List<Book> GetBooksByAuthorName(string authorName)
    {
        var booksFromDb = new List<Book>();
        foreach (var book in books)
        {
            if (book.AuthorsName.Contains(authorName))
            {
                booksFromDb.Add(book);
            }
        }
        return booksFromDb;
    }
    public bool AddReaderToBook(Guid bookId, string readerName)
    {
        var excist = false;
        foreach (var book in books)
        {
            if(book.Id == bookId)
            {
                book.ReadersName.Add(readerName);
                excist = true;
            }
        }
        return excist;
    }
    public bool AddAuthorToBook(Guid bookId, string authorName)
    {
        var excist = false;
        foreach(var book in books)
        {
            if(book.Id == bookId)
            {
                book.AuthorsName.Add(authorName);
                excist= true;
            }
        }
        return excist;
    }
}
