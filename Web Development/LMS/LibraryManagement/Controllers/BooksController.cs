
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

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var book = db.Books.Find(id);
        if(book is null)
            return NotFound($"Book with id {id} is not found");

        return View(book);
    }

    [HttpPost]
    public IActionResult Edit(Book book)
    {
        db.Books.Update(book);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

}
