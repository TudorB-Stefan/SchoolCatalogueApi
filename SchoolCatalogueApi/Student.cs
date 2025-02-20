using System.Numerics;

namespace SchoolCatalogueApi;

public class Student
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public List<int> Grades { get; set; } = new List<int>();
    public int SClassId { get; set; }
    public SClass SClass { get; set; } = null;
    public double AvgGrade()
    {
        return Grades.Sum()* 1.0 / Grades.Count;
    }
    public bool Passing()
    {
        return AvgGrade() >= 5 ? true : false;
    }
}