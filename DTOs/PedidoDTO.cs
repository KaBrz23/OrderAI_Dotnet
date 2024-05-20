using System.ComponentModel.DataAnnotations;

namespace OrderAI_Dotnet.DTOs;

public class PedidoDTO
{
    [Required]
    public decimal ValorTotal { get; set; }
    [Required]
    public decimal FreteEntrega { get; set; }
    [Required]
    public string DataPedido { get; set; } = string.Empty;
    [Required]
    public string DataEntrega { get; set; } = string.Empty;
}