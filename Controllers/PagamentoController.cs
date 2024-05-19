using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OrderAI_Dotnet.Data;
using OrderAI_Dotnet.DTOs;
using OrderAI_Dotnet.Models;

namespace OrderAI_Dotnet.Controllers;

public class PagamentoController : Controller
{
    private readonly DataContext _dataContext;
    private readonly ILogger<PagamentoController> _logger;

    public PagamentoController(ILogger<PagamentoController> logger, DataContext dataContext)
    {
        _dataContext = dataContext;
        _logger = logger;
    }
    
    public IActionResult Pagamento()
    {
        return View();
    }
    
    public IActionResult CadastrarPagamento(PagamentoDTO request)
    {
        var pag = _dataContext.TabelaPagamento.FirstOrDefault(x => x.num_cartao == request.num_cartao);
        if (pag != null)
        {
            return BadRequest("Cartão já existe");
        }
        Pagamento newPag = new Pagamento { 
            num_cartao = request.num_cartao,
            nome_cartao = request.nome_cartao,
            data_validade = request.data_validade,
            cvv = request.cvv,
            apelido_cartao = request.apelido_cartao,
        };
        _dataContext.Add(newPag);
        _dataContext.SaveChanges();
        return RedirectToAction("Index", "Home");
    }
    
    public IActionResult DeletarPagamento(PagamentoDTO request)
    {
        var pag = _dataContext.TabelaPagamento.FirstOrDefault(x => x.apelido_cartao == request.apelido_cartao);
        if (pag == null)
        {
            return BadRequest("Cartão não existe");
        }
        _dataContext.TabelaPagamento.Remove(pag);
        return RedirectToAction("Index", "Home");
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}