using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OrderAI_Dotnet.Data;
using OrderAI_Dotnet.DTOs;
using OrderAI_Dotnet.Models;

namespace OrderAI_Dotnet.Controllers;

public class PedidoController : Controller
{
    private readonly DataContext _dataContext;
    private readonly ILogger<PedidoController> _logger;

    public PedidoController(ILogger<PedidoController> logger, DataContext dataContext)
    {
        _dataContext = dataContext;
        _logger = logger;
    }
    
    public IActionResult Pedido()
    {
        return View();
    }
    
    
    public IActionResult RealizarPedido(PedidoDTO request)
    {
        Pedido newPed = new Pedido { 
            ValorTotal = request.valor_total,
            FreteEntrega = request.frete_entrega,
            DataPedido = request.data_pedido,
            DataEntrega = request.data_entrega,
        };
        _dataContext.Add(newPed);
        _dataContext.SaveChanges();
        return RedirectToAction("Index", "Home");
    }
    
    public IActionResult CancelarPedido(int id)
    {
        var ped = _dataContext.TabelaPedido.Find(id);
        if (ped == null)
        {
            return BadRequest("Pedido não existe");
        }
        _dataContext.TabelaPedido.Remove(ped);
        return RedirectToAction("Index", "Home");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}