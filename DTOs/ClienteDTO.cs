using PruebaTecnica.Models;
namespace PruebaTecnica.DTOs
{
    public class ClienteDTO
    {
    public required string Identificacion { get; set; }
    public required string Nombre { get; set; }
    public required string Apellido { get; set; }
    public required string Email { get; set; }
    public required string Telefono { get; set; }
    }
}
