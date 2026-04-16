using Microsoft.AspNetCore.Mvc;
using MinhaApi.Models;

namespace MinhaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private static List<Produto> produtos = new();

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(produtos);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Produto produto)
    {
        produtos.Add(produto);
        return Ok(produto);
    }
}