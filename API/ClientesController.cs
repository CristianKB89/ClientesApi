using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Services;
using PruebaTecnica.DTOs;

namespace PruebaTecnica.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteService _service;
        public ClientesController(ClienteService service)
        {
            _service = service;
        }

        /// <summary>
        /// Obtiene los datos de un cliente por su identificación.
        /// </summary>
        /// <param name="identificacion">Número de identificación del cliente</param>
        /// <returns>Datos del cliente</returns>
        [HttpGet("{identificacion}")]
        public ActionResult<ClienteDTO> Get(string identificacion)
        {
            var cliente = _service.GetClientePorIdentificacion(identificacion);
            if (cliente == null)
                return NotFound(new { mensaje = "El cliente no existe" });
            return Ok(cliente);
        }
    }
}