using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTecnica.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string IdFiscal { get; set; }
        public string NombreCompleto { get; set; }
        public string ApellidoCompleto { get; set; }
        public string CorreoElectronico { get; set; }
        public string NumeroTelefono { get; set; }
    }
}
