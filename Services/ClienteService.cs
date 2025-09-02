using PruebaTecnica.DTOs;
using PruebaTecnica.Models;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Services
{
    public class ClienteService
    {
        private readonly ClienteRepository _repository;
        public ClienteService(ClienteRepository repository)
        {
            _repository = repository;
        }

        public ClienteDTO GetClientePorIdentificacion(string identificacion)
        {
            var cliente = _repository.GetByIdentificacion(identificacion);
            if (cliente == null) return null!;
            return new ClienteDTO
            {
                Identificacion = cliente.IdFiscal,
                Nombre = cliente.NombreCompleto,
                Apellido = cliente.ApellidoCompleto,
                Email = cliente.CorreoElectronico,
                Telefono = cliente.NumeroTelefono
            };
        }
    }
}
