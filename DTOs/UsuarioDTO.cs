using System.ComponentModel.DataAnnotations;

namespace OrderAI_Dotnet.DTOs;

public class UsuarioDTO
{
    [Required]
    public string nome { get; set; } = string.Empty;
    [Required]
    [EmailAddress]
    public string email { get; set; } = string.Empty;
    [Required]
    [DataType(DataType.Password)]
    public string senha { get; set; } = string.Empty;
    [Required]
    [DataType(DataType.PhoneNumber)]
    public string telefone { get; set; } = string.Empty;
    [Required]
    public string endereco { get; set; } = string.Empty;
    [Required]
    public string cep { get; set; } = string.Empty;
    [Required]
    public string cidade { get; set; } = string.Empty;
    [Required]
    public string estado { get; set; } = string.Empty;
    [Required]
    public string cpf { get; set; } = string.Empty;
    public string data_cadastro { get; set; }
    [Required]
    public string data_nascimento { get; set; }
    [Required]
    public string sexo { get; set; } = string.Empty;
}