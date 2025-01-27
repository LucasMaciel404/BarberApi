using Barber.Data;
using Barber.DTO;
using Barber.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Barber.Controllers;
[ApiController]
[Route("api/v1/[controller]")]
public class UsuarioController : Controller
{
    private ConnectionContext _context;
    public UsuarioController(ConnectionContext contexto)
    {
        _context = contexto;
    }

    [Authorize]
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var usuario = _context.Usuario;
        return Ok(usuario);
    }

    //[Authorize]
    [HttpPost]
    public async Task<IActionResult> Set([FromBody] UsuarioDTO usuario)
    {
        _context.Usuario.Add(usuario);
        _context.SaveChanges();

        return Ok();
    }

}
