using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OrderAI_Dotnet.Data;
using OrderAI_Dotnet.DTOs;
using OrderAI_Dotnet.Models;

namespace OrderAI_Dotnet.Controllers;

public class ItemPedidoController : Controller
{
    private readonly DataContext _dataContext;
    private readonly ILogger<ItemPedidoController> _logger;

    public ItemPedidoController(ILogger<ItemPedidoController> logger, DataContext dataContext)
    {
        _dataContext = dataContext;
        _logger = logger;
    }
    
    public IActionResult ItemPedido()
    {
        return View();
    }
    
    public IActionResult CadastrarItem(ItemPedidoDTO request)
    {
        ItemPedido newItem = new ItemPedido { 
            nome = request.nome,
            descricao = request.descricao,
            quantidade = request.quantidade,
            preco = request.preco,
            recomendacao = request.recomendacao,
        };
        _dataContext.Add(newItem);
        _dataContext.SaveChanges();
        return RedirectToAction("Index", "Home");
    }
    
    public IActionResult DeletarPedido(ItemPedidoDTO request)
    {
        var item = _dataContext.TabelaItemPedido.FirstOrDefault(x => x.nome == request.nome);
        if (item == null)
        {
            return BadRequest("Item não existe");
        }
        _dataContext.TabelaItemPedido.Remove(item);
        return RedirectToAction("Index", "Home");
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}