using System.ComponentModel.DataAnnotations;

namespace OrderAI_Dotnet.DTOs;

public class LoginDTO
{
    [Required]
    [EmailAddress]
    public string email { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string senha { get; set; }
}