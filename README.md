# .NET Challenge

Simulacro de una WebAPI de gestión de ordenes de inversión construida en .NET Core 8 usando Clean Architecture

# Descripción del Challenge

Elaborar un API en .NET Core 8 que permita la gestión de ordenes de inversión.
La API debe permitir a los usuarios realizar operaciones CRUD (Create,Read,Update,Delete).
Para realizar este ejercicio se utilizó Entity Framework Core para gestionar las entidades y realizar operaciones en base de datos SQL Server.
El modelado de las tablas se hizo mediante la tecnica Code-First y se fue implementando mediante migraciones usando Entity Framework Core Tools.

El diseño de las capas de la aplicación es la siguiente:
  - Core: Gestiona el nucleo principal de las entidades, DTO's (Data Transfer Object) , vistas e interfaces.
  - Infrastructure: Gestiona el acceso a datos , administración de la base datos y repositorios.
  - Services: Logica de negocio y validaciones.
  - Web: Controladores y acceso mediante el protocolo HTTP.
    
# Paquetes NuGet necesarios para el proyecto

Recomiendo usar la consola de Package Manager Console embedido en Visual Studio

- Instalamos Entity Framework Core en la capa Infrastructure

dotnet tool install --global dotnet-ef .
dotnet add OrdenesPPI.Infrastructure/OrdenesPPI.Infrastructure.csproj package Microsoft.EntityFrameworkCore  
dotnet add OrdenesPPI.Infrastructure/OrdenesPPI.Infrastructure.csproj package Microsoft.EntityFrameworkCore.Design  
dotnet add OrdenesPPI.Infrastructure/OrdenesPPI.Infrastructure.csproj package Microsoft.EntityFrameworkCore.SqlServer  
dotnet add OrdenesPPI.Infrastructure/OrdenesPPI.Infrastructure.csproj package Microsoft.EntityFrameworkCore.Tools  

- Implementamos Entity Framework Core Design en la capa Web

dotnet add OrdenesPPI.Web/OrdenesPPI.Web.csproj package Microsoft.EntityFrameworkCore.Design 

- Instalando FluentValidation en la capa Service
dotnet add OrdenesPPI.Services/OrdenesPPI.Services.csproj package FluentValidation

- Instalando AutoMapper y Dependency Injection sobre la capa Web
Si llega a instalar la version 13 de Automapper ir a Administracion de Paquetes Nuget y hacer un downgrade a la 12 para asegurar compatibilidad

dotnet add OrdenesPPI.Web/OrdenesPPI.Web.csproj package AutoMapper --version 12.0.1
dotnet add OrdenesPPI.Web/OrdenesPPI.Web.csproj package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1

Si bien instalar los paquetes por scripts agiliza la creación del proyecto, en caso de que no tome correctamente algun package recomiendo desinstalarlo mediante la pantalla de administrador de paquetes y reinstalarlo mediante la misma.

# Despligue de base de datos

Use el script generado en el archivo [DataBaseScripts](DataBaseScripts.sql) para implementar la base de datos con las tablas e información completa para probar la aplicación.

# Diseño de base datos

<a href="https://imgur.com/a/pOEMhv7"><img src="https://i.imgur.com/5mrrQnG.png" width="500"></a>

# Configuración de la cadena de conexión entre la app y base de datos.

Abra el archivo appsettings.Development.json y modifique el valor "Default" por la correspondiente conexión.

# Ejecución de la aplicación

Puede usar la versión embebida de IIS (Internet Information Services), en caso que Visual Studio pregunte por HTTPS o SSL , no habilitar sino en caso contrario la app no podrá iniciar correctamente.

<a href="https://i.imgur.com/6OTYRkX.png"><img src="https://i.imgur.com/6OTYRkX.png" width="1000"></a>

# Uso de los metodos de la API
- **Activo**
  - api/Activo (GET)
  - /api/Activo/{Id} (GET)
- **TipoActivo**
  - api/TipoActivo (GET)
- **Cuenta**
  - api/Cuenta (GET)
- **Estado**
  - api/Estado (GET)
- **Orden**
  - api/Orden (GET)
  - api/Orden/{Id} (GET)
  - api/Orden (POST)
  - api/Orden (PUT)
  - /api/Orden/{id} (DELETE)

Para probar la creacion de ordenes tiene ejemplos en el archivo archivo [SampleordenData](SampleordenData.json)

# Autor

  - **Marcos Gonzalez** - *Senior .Net Developer* - 
    
Cualquier comentario o aporte es bienvenido, pueden escribirme a mgonzalezsoft@outlook.com
