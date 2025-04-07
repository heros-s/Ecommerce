using Microsoft.AspNetCore.Mvc;
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

    private readonly AppDataContext _context;
    public ProdutoController(AppDataContext context)
    {
        _context = context;
    }
    //Exemplo de um EndPoint dentro de um Controller
    [HttpPost("cadastrar")]
    public IActionResult Cadastrar([FromBody] ProdutoController produto)
    {
        _context.Produtos.Add(produto);
        _context.SaveChanges();
        return Created("", produto);
    }

}