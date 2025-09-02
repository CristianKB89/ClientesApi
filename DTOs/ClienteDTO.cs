using PruebaTecnica.Models;
namespace PruebaTecnica.DTOs
{
    public class ClienteDTO
    {
        public string Identificacion { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Telefono { get; set; } = null!;
    }
}
