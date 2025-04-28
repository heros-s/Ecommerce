using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers;

[ApiController]

[Route("api/produto")]
public class ProdutoController : ControllerBase
{
    //Exemplo de um método dentro de uma classe
    /*
    public string Metodo()
    {
        return "";
    }
    */

    private readonly IProdutoRepository _produtoRepository;
    public ProdutoController(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    //Exemplo de um EndPoint dentro de um Controller
    [HttpPost("cadastrar")]
    [Authorize(Roles = "administrador")]
    public IActionResult Cadastrar([FromBody] Produto produto)
    {
        _produtoRepository.Cadastrar(produto);
        return Created("", produto);
    }

    [HttpGet("listar")]
    [Authorize]
    public IActionResult Listar()
    {
        return Ok(_produtoRepository.Listar());
    }

}