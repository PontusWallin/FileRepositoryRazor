using System.ComponentModel.DataAnnotations;

namespace FileRepositoryRazor.Models;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string? Nickname { get; set; }
    
    [Required]
    [MinLength(8)]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
    
    [Required]
    public string? FirstName { get; set; }
    
    [Required]
    public string? Surname { get; set; }
    
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
}