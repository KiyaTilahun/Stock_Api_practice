using System.ComponentModel.DataAnnotations;

namespace AspApi.Dtos.Accounts;

public class RegisterDto
{
    [Required]
    [MaxLength(50)]
    public string? UserName { get; set; }
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    [Required]
    [MinLength(6)]
    public string? Password { get; set; }
}