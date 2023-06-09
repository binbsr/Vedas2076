//Book (Id, Title, Author, Price, Publisher, Language, Edition, Published Date)

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Book
{
    public int Id { get; set; }

    [Required]
    [MinLength(2, ErrorMessage = "Book title must be at least 2 letters")]
    public string Title { get; set; }
    
    public string Author { get; set; }
    public double Price { get; set; }    
    public string Publisher { get; set; }
    public string Language { get; set; }
    public string Edition { get; set; }

    [DisplayName("Publish Date")]
    [DataType(DataType.Date)]
    public DateTime PublishedDate { get; set; }
}
