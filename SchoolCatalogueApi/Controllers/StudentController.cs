using Microsoft.AspNetCore.Mvc;
using SchoolCatalogueApi.Data;
namespace SchoolCatalogueApi.Controllers;

[Route("api/[controller]")]
[ApiController]

public class StudentController(SchoolCatalogueDbContext context):ControllerBase
{
    private readonly SchoolCatalogueDbContext _context = context;
    // [HttpGet]
    // [HttpGet("{id}")]
    // [HttpPost] 
    // [HttpPut("{id}")]
    // [HttpDelete("{id}")]
}