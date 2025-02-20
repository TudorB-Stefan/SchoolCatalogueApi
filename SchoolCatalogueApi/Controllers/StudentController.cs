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
    // [HttpGet("{id}")]
    // [HttpPost] 
    // [HttpPut("{id}")]
    // [HttpDelete("{id}")]
}

