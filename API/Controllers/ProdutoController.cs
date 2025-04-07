using Microsoft.AspNetCore.Mvc;
namespace API.Controllers;

[ApiController]
[Route("api/produto")]
public class ProdutoController : ControllerBase
{
    //Exemplo de um método dentro de uma classe
    public string Metodo()
    {
        return "";
    }

    //Exemplo de um EndPoint dentro de um Controller
    [HttpGet("helloworld")]
    public IActionResult Helloworld()
    {
        return Ok("Hello World!");
    }

}