using Microsoft.EntityFrameworkCore;

public class AcademyContext(DbContextOptions<AcademyContext> options) : DbContext(options)
{
    public DbSet<AcademyCW.Models.Direction> Directions { get; set; } = default!;
}
