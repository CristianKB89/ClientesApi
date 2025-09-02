# PruebaTecnica - API Clientes (.NET 7)

## Estructura del proyecto

```
/PruebaTecnica
│
├── Controllers/         # API: controladores y endpoints
├── Services/            # Lógica de negocio
├── Repositories/        # Acceso a datos con Entity Framework Core
├── DTOs/                # Objetos de transferencia de datos
├── Models/              # Entidades de base de datos
├── Context/             # DbContext de EF Core
├── Migrations/          # Migraciones de EF Core
├── Program.cs           # Configuración de la API y dependencias
├── appsettings.json     # Configuración de la base de datos
└── PruebaTecnica.csproj # Archivo de proyecto
```

## Requisitos
- Visual Studio 2022
- .NET 7 SDK
- SQL Server 2019 o superior

## Configuración rápida
1. **Clona o descomprime el proyecto**
2. **Abre la solución en Visual Studio 2022**
3. **Restaura los paquetes NuGet** (Visual Studio lo hace automáticamente al abrir el proyecto)
4. **Configura la cadena de conexión en `appsettings.json`**
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost,1433;Database=DBClientes;User Id=USUARIO;Password=TU_PASSWORD;TrustServerCertificate=True;Encrypt=False;"
   }
   ```
   > Reemplaza `USUARIO` y `TU_PASSWORD` por tus propios datos de acceso. No compartas tu clave personal.
5. **Ejecuta la migración única**
   - Abre la Consola de Administrador de Paquetes o terminal y ejecuta:
     ```sh
     dotnet ef database update
     ```
   - Esto creará la estructura de la base de datos automáticamente.
6. **Crea el procedimiento almacenado en SQL Server**
   - Ejecuta el siguiente script en tu base de datos:
     ```sql
     CREATE PROCEDURE sp_ObtenerClientePorIdentificacion
         @Identificacion NVARCHAR(50)
     AS
     BEGIN
         SELECT * FROM Clientes WHERE Identificacion = @Identificacion;
     END
     GO
     ```
7. **Agrega datos de ejemplo si lo deseas**
   - Puedes usar este script:
     ```sql
     INSERT INTO Clientes (Identificacion, Nombre, Apellido, Email, Telefono) VALUES
     ('12345678', 'Juan', 'Pérez', 'juan.perez@email.com', '111111111'),
     ('87654321', 'Ana', 'García', 'ana.garcia@email.com', '222222222'),
     ('11223344', 'Luis', 'Martínez', 'luis.martinez@email.com', '333333333'),
     ('44332211', 'María', 'López', 'maria.lopez@email.com', '444444444'),
     ('99887766', 'Carlos', 'Sánchez', 'carlos.sanchez@email.com', '555555555');
     ```
8. **Inicia la API**
   - Presiona F5 o haz clic en "Iniciar depuración".
9. **Prueba los endpoints en Swagger**
   - Accede a `https://localhost:puerto/swagger` (el puerto lo muestra Visual Studio al iniciar la API).

## Endpoints principales
- `GET /api/clientes/{identificacion}`: Consulta cliente por identificación


---

¡Listo para compartir y probar en Visual Studio 2022!
