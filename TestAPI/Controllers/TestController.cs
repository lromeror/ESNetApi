using Microsoft.AspNetCore.Mvc;
using TestAPI.Context;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    private readonly BackEndContext _context;

    public TestController(BackEndContext context)
    {
        _context = context;
    }

    // Acción para probar la conexión a la base de datos
    [HttpGet("testconnection")]
    public async Task<IActionResult> TestConnection()
    {
        try
        {
            var canConnect = await _context.Database.CanConnectAsync();
            if (canConnect)
            {
                return Ok("Conexión exitosa a la base de datos");
            }
            else
            {
                return StatusCode(500, "No se pudo conectar a la base de datos");
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error al conectar a la base de datos: {ex.Message}");
        }
    }
}
