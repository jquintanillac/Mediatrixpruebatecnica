using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SB.MediatrixPruebaTecnica.Application.Servicios;
using SB.MediatrixPruebaTecnica.Core.Dominio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SB.MediatrixPruebaTecnica.WebApi.Controllers
{
   
    [ApiController]
    [Route("api/Gubernamental")]
    [Authorize]
    public class EntidadGubernamentalController : ControllerBase
    {
        private readonly ManejadorEntidadGubernamental _manejadorGubernamental;

        public EntidadGubernamentalController(ManejadorEntidadGubernamental manejadorGubernamental)
        {
            _manejadorGubernamental = manejadorGubernamental;
        }

        // Obtener todas las entidades
        [HttpGet("getall")]
        public async Task<IActionResult> ObtenerTodas()
        {
            try
            {
                var entidades = await _manejadorGubernamental.ObtenerTodasAsync();
                return Ok(entidades);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        // Crear una nueva entidad
        [HttpPost("add")]
        public async Task<IActionResult> Crear([FromBody] EntidadGubernamental nuevaEntidad)
        {
            try
            {
                await _manejadorGubernamental.AgregarAsync(nuevaEntidad);
                return CreatedAtAction(nameof(ObtenerTodas), new { id = nuevaEntidad.Id }, nuevaEntidad);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        // Actualizar una entidad existente
        [HttpPut("edit/{id}")]
        public async Task<IActionResult> Actualizar(int id, [FromBody] EntidadGubernamental entidadActualizada)
        {
            try
            {
                await _manejadorGubernamental.ActualizarAsync(id, entidadActualizada);
                return NoContent();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        // Eliminar una entidad
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            try
            {
                await _manejadorGubernamental.EliminarAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

    }
}
