using Microsoft.EntityFrameworkCore;
using PlacementApp.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<PlacementApplication> PlacementApplications { get; set; }
}