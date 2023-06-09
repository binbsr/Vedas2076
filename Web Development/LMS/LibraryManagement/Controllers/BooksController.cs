
using Microsoft.AspNetCore.Mvc;

public class BooksController : Controller
{
    static List<Book> books = new List<Book>()
    {
        new Book
        {
            Id = 1,
            Title = "Chemistry",
            Author = "Stephen",
            Edition = "III",
            Language = "En",
            Price = 456.34,
            Publisher = "LPE",
            PublishedDate = DateTime.Now
        },
        new Book
        {
            Id = 1,
            Title = "Physics",
            Author = "Peter",
            Edition = "II",
            Language = "En",
            Price = 656.34,
            Publisher = "LPE",
            PublishedDate = DateTime.Now
        },
        new Book
        {
            Id = 1,
            Title = "Data Structure and Algorithms",
            Author = "Ram",
            Edition = "I",
            Language = "Np",
            Price = 1056.34,
            Publisher = "LPE",
            PublishedDate = DateTime.Now
        }
    };

    [HttpGet]
    public IActionResult Index()
    {
        return View(books);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Book book)
    {
        // Do something with book object
        books.Add(book);
        return RedirectToAction("Index");
    }

}
