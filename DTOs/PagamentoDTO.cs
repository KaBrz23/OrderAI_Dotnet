using System.ComponentModel.DataAnnotations;

namespace OrderAI_Dotnet.DTOs;

public class PagamentoDTO
{
    [Required]
    public string num_cartao { get; set; } = string.Empty;
    [Required]
    public string nome_cartao { get; set; } = string.Empty;
    [Required]
    public string data_validade { get; set; } = string.Empty;
    [Required]
    public int cvv { get; set; }
    public string apelido_cartao { get; set; } = string.Empty;
}