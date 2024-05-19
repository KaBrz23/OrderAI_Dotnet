using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OrderAI_Dotnet.Data;
using OrderAI_Dotnet.DTOs;
using OrderAI_Dotnet.Models;

namespace OrderAI_Dotnet.Controllers;

public class UsuarioController : Controller
{
    private readonly DataContext _dataContext;
    private readonly ILogger<UsuarioController> _logger;

    public UsuarioController(ILogger<UsuarioController> logger, DataContext dataContext)
    {
        _dataContext = dataContext;
        _logger = logger;
    }

    public IActionResult Cadastro()
    {
        return View();
    }
    
    public IActionResult Login()
    {
        return View();
    }
    
    public IActionResult EfetuarCadastro(UsuarioDTO request)
    {
        var user = _dataContext.TabelaUsuario.FirstOrDefault(x => x.email == request.email);
        if (user != null)
        {
            return BadRequest("Usuário ja existe");
        }
        Usuario newUser = new Usuario { 
            nome = request.nome,
            email = request.email,
            senha = request.senha,
            telefone = request.telefone,
            endereco = request.endereco,
            cep = request.cep,
            cidade = request.cidade,
            estado = request.estado,
            cpf = request.cpf,
            dataCadastro = request.data_cadastro,
            dataNascimento = request.data_nascimento,
            sexo = request.sexo,
        };
        _dataContext.Add(newUser);
        _dataContext.SaveChanges();
        return RedirectToAction("Login");
    }
    
    public IActionResult EfetuarLogin(LoginDTO request) 
    {
        var find = _dataContext.TabelaUsuario.FirstOrDefault(x => x.email == request.email);
        if (find == null) 
        {
            return BadRequest("E-mail não cadastrado!");
        }
        if(find.senha != request.senha)
        {
            return BadRequest("Senha inválida");
        }
        return RedirectToAction("Index", "Home");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}