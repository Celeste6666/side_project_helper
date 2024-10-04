using System.ComponentModel.DataAnnotations;

namespace SideProjectHelper.Models;

public class User
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "First Name")]
    [MaxLength(50)]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    [MaxLength(50)]
    public string LastName { get; set; }

    [Required]
    [MaxLength(100)]
    public string Email { get; set; }
    
    [Required]
    public string Password { get; set; }

    public List<Project>? Projects { get; } = [];
}