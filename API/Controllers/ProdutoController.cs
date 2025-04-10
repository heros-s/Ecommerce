using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Models;

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
    public IActionResult Cadastrar([FromBody] Produto produto)
    {
        _produtoRepository.Cadastrar(produto);
        _produtoRepository.SaveChanges();
        return Created("", produto);
    }

    [HttpGet("listar")]
    public IActionResult Listar()
    {
        return Ok(_produtoRepository.Listar());
    }

}