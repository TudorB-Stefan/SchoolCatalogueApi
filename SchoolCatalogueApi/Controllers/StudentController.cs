using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolCatalogueApi.Data;
namespace SchoolCatalogueApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController(SchoolCatalogueDbContext context) : ControllerBase
{
    private readonly SchoolCatalogueDbContext _context = context;

    [HttpGet]
    public async Task<ActionResult<List<Student>>> GetStudents()
    {
        return Ok(await _context.Students.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Student>> GetStudentsById(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student == null)
            return NotFound();
        return Ok(student);
    }
    [HttpPut]
    public async Task<ActionResult<Student>> AddStudentsClassId(Student newStudent,int id)
    {
        if (newStudent is null)
            return BadRequest();
        // _context.Students.Add(newStudent);
        // await _context.SaveChangesAsync();
        // return CreatedAtAction(nameof(GetStudentsById),new {id=newStudent.Id},newStudent);
        
        var sClass = await _context.Students.FindAsync(id);
        _context.SClasses.Add()
    }
    // [HttpPut("{id}")]
    // [HttpDelete("{id}")]
}

