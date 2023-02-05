using System.ComponentModel.DataAnnotations;

namespace FileRepositoryRazor.Models;

public class File
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Extension { get; set; }
    
    [Required]
    public int Size { get; set; }
    
    [Required]
    public int FolderId { get; set; }
    
    [Required]
    public int UserId { get; set; }
    
    public Folder Folder { get; set; }
    
    public User User { get; set; }
}