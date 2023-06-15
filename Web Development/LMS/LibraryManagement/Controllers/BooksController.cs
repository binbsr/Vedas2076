
using LibraryManagement.Data;
using LibraryManagement.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

public class BooksController : Controller
{
    LMContext db = new();
    BooksRepository booksRepository = new();

    [HttpGet]
    public IActionResult Index(string searchText = "")
    {
        var books = booksRepository.Get(searchText);
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
        booksRepository.Insert(book);

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var book = db.Books.Find(id);
        if (book is null)
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

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var book = db.Books.Find(id);
        if (book is null)
            return NotFound($"Book with id {id} is not found");

        return View(book);
    }

    [HttpPost]
    public IActionResult Delete(Book book)
    {
        db.Books.Remove(book);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

}
