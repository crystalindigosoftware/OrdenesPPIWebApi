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

# Ejecución de la aplicación

Puede usar la versión embebida de IIS (Internet Information Services), en caso que Visual Studio pregunte por HTTPS o SSL , no habilitar sino en caso contrario la app no podrá iniciar correctamente.

<a href="https://i.imgur.com/6OTYRkX.png"><img src="https://i.imgur.com/6OTYRkX.png" width="1000"></a>

### Sample Tests

Explain what these tests test and why

    Give an example

### Style test

Checks if the best practices and the right coding style has been used.

    Give an example

## Deployment

Add additional notes to deploy this on a live system

## Built With

  - [Contributor Covenant](https://www.contributor-covenant.org/) - Used
    for the Code of Conduct
  - [Creative Commons](https://creativecommons.org/) - Used to choose
    the license

## Contributing

Please read [CONTRIBUTING.md](CONTRIBUTING.md) for details on our code
of conduct, and the process for submitting pull requests to us.

## Versioning

We use [Semantic Versioning](http://semver.org/) for versioning. For the versions
available, see the [tags on this
repository](https://github.com/PurpleBooth/a-good-readme-template/tags).

## Authors

  - **Billie Thompson** - *Provided README Template* -
    [PurpleBooth](https://github.com/PurpleBooth)

See also the list of
[contributors](https://github.com/PurpleBooth/a-good-readme-template/contributors)
who participated in this project.

## License

This project is licensed under the [CC0 1.0 Universal](LICENSE.md)
Creative Commons License - see the [LICENSE.md](LICENSE.md) file for
details

## Acknowledgments

  - Hat tip to anyone whose code is used
  - Inspiration
  - etc
