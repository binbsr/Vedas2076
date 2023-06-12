
using LibraryManagement.Data;
using Microsoft.AspNetCore.Mvc;

public class BooksController : Controller
{
    LMContext db = new();

    [HttpGet]
    public IActionResult Index()
    {
        var books = db.Books.ToList();

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
        db.Add(book);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

}
