namespace SideProjectHelper.Models;

public class InterestUserProject
{
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    
    public int ProjectId { get; set; }
    public Project Project { get; set; } = null!;
}