using LibraryManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.Repositories;
public class BooksRepository
{
    LMContext db = new();

    public List<Book> Get(string searchText = "")
    {
        List<Book> books = new();
        if (searchText == "")
            books = db.Books.ToList();
        else
            books = db.Books.Where(x => x.Title.Contains(searchText) || x.Author.Contains(searchText)).ToList();
        return books;
    }

    public Book Get(int id)
    {
        var book = db.Books.Find(id);
        return book;
    }


    public Book Insert(Book book)
    {
        db.Books.Add(book);
        db.SaveChanges();
        return book;
    }

    public Book Edit(Book book)
    {
        db.Books.Update(book);
        db.SaveChanges();
        return book;
    }
}
