using PruebaTecnica.Context;
using Microsoft.Data.SqlClient;
using System.Data;
using PruebaTecnica.Models;
using Microsoft.EntityFrameworkCore;

namespace PruebaTecnica.Repositories
{
    public class ClienteRepository
    {
        private readonly AppDbContext _context;
        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public Cliente GetByIdentificacion(string identificacion)
        {
            var connection = (SqlConnection)_context.Database.GetDbConnection();
            connection.Open();
            using var command = new SqlCommand("sp_ObtenerClientePorIdentificacion", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Identificacion", identificacion);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Cliente
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    IdFiscal = reader.GetString(reader.GetOrdinal("Identificacion")),
                    NombreCompleto = reader.GetString(reader.GetOrdinal("Nombre")),
                    ApellidoCompleto = reader.GetString(reader.GetOrdinal("Apellido")),
                    CorreoElectronico = reader.GetString(reader.GetOrdinal("Email")),
                    NumeroTelefono = reader.GetString(reader.GetOrdinal("Telefono"))
                };
            }
            return null!;
        }
    }
}
