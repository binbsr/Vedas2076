
namespace LibraryManagement.Models;
public class Faculty
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Enums.Stream Stream { get; set; }

    public List<Student>? Students { get; set; }
}
