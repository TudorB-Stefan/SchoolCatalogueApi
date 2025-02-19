namespace SchoolCatalogueApi;

public class SClass
{
    public int Id { get; set; }
    public int? Year { get; set; }
    public char? Serie { get; set; }
    public bool? Valid { get; set; }
    public List<Student> Students { get; } = new List<Student>();
}