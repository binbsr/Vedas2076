using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data;
public class LMContext: DbContext
{
    public DbSet<Book> Books { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=LibraryManagement;Integrated Security=True;");
    }
}
