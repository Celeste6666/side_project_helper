using Microsoft.EntityFrameworkCore;
using SideProjectHelper.Models;

namespace SideProjectHelper.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Project> Project { get; set; }
    public DbSet<User> User { get; set; }
}