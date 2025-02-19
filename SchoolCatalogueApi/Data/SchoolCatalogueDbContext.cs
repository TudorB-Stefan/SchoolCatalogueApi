using Microsoft.EntityFrameworkCore;
namespace SchoolCatalogueApi.Data;

public class SchoolCatalogueDbContext(DbContextOptions<SchoolCatalogueDbContext> options) : DbContext(options)
{
    public DbSet<SClass> SClasses => Set<SClass>();
    public DbSet<Student> Students => Set<Student>();
}