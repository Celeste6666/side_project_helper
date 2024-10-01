using System.ComponentModel.DataAnnotations;

namespace SideProjectHelper.Models;

public class Project
{
    public int ProjectId { get; set; }
    public int UserId { get; set; }
    public User user { get; }

    [Required]
    public string Title { get; set; }
    public string Description { get; set; }
}