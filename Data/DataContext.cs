using Microsoft.EntityFrameworkCore;
using OrderAI_Dotnet.Models;

namespace OrderAI_Dotnet.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    
    public DbSet<Usuario> TabelaUsuario { get; set; }
    public DbSet<Pedido> TabelaPedido { get; set; }
    public DbSet<ItemPedido> TabelaItemPedido { get; set; }
    public DbSet<Pagamento> TabelaPagamento { get; set; }
}