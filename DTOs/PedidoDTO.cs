using System.ComponentModel.DataAnnotations;

namespace OrderAI_Dotnet.DTOs;

public class PedidoDTO
{
    [Required]
    public decimal valor_total { get; set; }
    [Required]
    public decimal frete_entrega { get; set; }
    [Required]
    public string data_pedido { get; set; } = string.Empty;
    [Required]
    public string data_entrega { get; set; } = string.Empty;
}