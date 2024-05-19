using System.ComponentModel.DataAnnotations;

namespace OrderAI_Dotnet.DTOs;

public class ItemPedidoDTO
{
    [Required]
    public string nome { get; set; } = string.Empty;
    [Required]
    public string descricao { get; set; } = string.Empty;
    [Required]
    public int quantidade { get; set; }
    [Required]
    public decimal preco { get; set; }
    [Required]
    public string recomendacao { get; set; } = string.Empty;
}