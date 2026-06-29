using Microsoft.AspNetCore.Mvc;

namespace DemoApi;

[ApiController]
[Route("api/[controller]")]
public class TareasController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Tarea>> Get()
    {
        return Ok(TareaRepository.ObtenerTodas());
    }

    [HttpPost]
    public ActionResult Post([FromBody] Tarea nueva)
    {
        TareaRepository.Agregar(nueva);
        return CreatedAtAction(nameof(Get), new { id = nueva.Id }, nueva);
    }
}