using System.ComponentModel.DataAnnotations;

namespace SideProjectHelper.Models;

public class Project
{
    public int ProjectId { get; set; }
    public int UserId { get; set; } = 1;
    public User User { get; set; }

    [Required] public string Title { get; set; }
    public string Description { get; set; }
    public string? Photo { get; set; }
}