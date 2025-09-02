using PruebaTecnica.Models;
namespace PruebaTecnica.DTOs
{
    public class ClienteDTO
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
