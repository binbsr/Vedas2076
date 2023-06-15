using LibraryManagement.Data;
using LibraryManagement.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        BooksRepository booksRepository = new();

        [HttpGet]
        public ActionResult<List<Book>> Get()
        {
            var books = booksRepository.Get();
            return books;
        }

        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            var book = booksRepository.Get(id);
            if(book is null)
                return NotFound();
            return book;
        }

        [HttpPost]
        public ActionResult<Book> Post(Book book)
        {
            booksRepository.Insert(book);
            return Created($"/books/{book.Id}", book);
        }

        [HttpPut]
        public ActionResult<Book> Put(Book book)
        {
            booksRepository.Edit(book);
            return NoContent();
        }
    }
}
