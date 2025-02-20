using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolCatalogueApi.Data;
namespace SchoolCatalogueApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SClassController(SchoolCatalogueDbContext context):ControllerBase
{
    private readonly SchoolCatalogueDbContext _context = context;

    [HttpGet]
    public async Task<ActionResult<List<SClass>>> GetSClass()
    {
        return Ok(await _context.SClasses.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Student>> GetSClassById(int id)
    {
        var sClass = await _context.SClasses.FindAsync(id);
        if (sClass == null)
            return NotFound();
        return Ok(sClass);
    }
    [HttpPost]
    public async Task<ActionResult<Student>> AddStudents(SClass newSClass)
    {
        if (newSClass is null)
            return BadRequest();
        
        newSClass.Serie=char.ToLower(newSClass.Serie);
        newSClass.Students = new List<Student>();
        
        _context.SClasses.Add(newSClass);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetSClassById),new {id=newSClass.Id},newSClass);
    }
    // [HttpPut("{id}")]
    // [HttpDelete("{id}")]
}
