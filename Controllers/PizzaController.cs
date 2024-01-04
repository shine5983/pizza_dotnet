using webapi_d.Models;
using webapi_d.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace webapi_d.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);
        if (pizza is null)
            return NotFound();
        return pizza;
    }
}