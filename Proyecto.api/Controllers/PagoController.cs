using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.api.DTOs;
using Proyecto.api.Utilitarios;
using Proyecto.BW.Interfaces.BW;

namespace Proyecto.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagoController : ControllerBase
    {
        private readonly IGestionarPagoBW gestionarPagoBW;

        public PagoController(IGestionarPagoBW gestionarPagoBW)
        {
            this.gestionarPagoBW = gestionarPagoBW;
        }


        [HttpPost("pagoGestion")]
        public async Task<IActionResult> RegistrarEvento([FromBody] PagoDTO pagoDTO)
        {
            try
            {
                var exito = await gestionarPagoBW.resgistrePago(MapperPago.MapperAPago(pagoDTO));
                if (exito)
                {
                    return Ok(true);
                }
                else
                {
                    return BadRequest(false);
                }
            }
            catch (Exception ex)
            {
                // Aquí podrías hacer un registro de errores o manejar la excepción según tu aplicación
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
    }
}
