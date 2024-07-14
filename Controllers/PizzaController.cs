using _Create_a_web_API_with_ASP.NET_Core_controllers.Models;
using _Create_a_web_API_with_ASP.NET_Core_controllers.Service;
using Microsoft.AspNetCore.Mvc;

namespace _Create_a_web_API_with_ASP.NET_Core_controllers.Controllers;


[ApiController]
[Route("[controller]")]

public class PizzaController : ControllerBase
{
    public PizzaController()
    {

    }

    
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() =>
     PizzaService.GetAll();


    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);

        if (pizza == null)
            return NotFound();

        return pizza;
    }
    // POST action

    // PUT action

    // DELETE action
}