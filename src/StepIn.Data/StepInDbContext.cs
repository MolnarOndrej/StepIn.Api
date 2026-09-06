using Microsoft.EntityFrameworkCore;

namespace StepIn.Data;

public class StepInDbContext : DbContext
{
    public StepInDbContext(DbContextOptions<StepInDbContext> options) : base(options)
    {
    }
}