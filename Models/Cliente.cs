using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTecnica.Models
{
    public class Cliente
    {
        public int Id { get; set; }
    public required string IdFiscal { get; set; }
    public required string NombreCompleto { get; set; }
    public required string ApellidoCompleto { get; set; }
    public required string CorreoElectronico { get; set; }
    public required string NumeroTelefono { get; set; }
    }
}
