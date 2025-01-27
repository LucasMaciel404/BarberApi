using Microsoft.AspNetCore.Mvc;
using Barber.Jwt;
using Barber.Models;
namespace Barber.Controllers;

[ApiController]
[Route("/v1/[controller]")]
public class AuthController : Controller
{
    [HttpPost]
    public IActionResult Auth(string email, string password)
    {
        var usuario = new Usuarios()
        {

            nome = "admin",
            role = "admin"
        };
        var tooken = TokenService.GenerateToken(usuario);

        return Ok(tooken);
    }
}
