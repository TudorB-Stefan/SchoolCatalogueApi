using System.Numerics;

namespace SchoolCatalogueApi;

public class Student
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Vector<int>? Grades { get; set; }
    public float? AvgGrade { get; set; }
    public int SClassId { get; set; }
    public SClass SClass { get; set; } = null;
}