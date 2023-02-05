using System.ComponentModel.DataAnnotations;

namespace FileRepositoryRazor.Models;

public class Folder
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string? Name { get; set; }
    
    [Required]
    public int? ParentId { get; set; }
    
    [Required]
    public int? UserId { get; set; }
    
    public Folder? Parent { get; set; }
    
    public User? User { get; set; }
    
    public List<Folder> Children { get; set; }
    
    public List<File> Files { get; set; }
}