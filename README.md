# Gestión de Usuarios con .NET Core
## Descripción del Proyecto
Este proyecto es una solución desarrollada con .NET Core, estructurada en capas utilizando Clean Architecture y con una interfaz en MVC. La plataforma permite gestionar una lista de usuarios, donde cada usuario tiene las siguientes propiedades:

- Nombre (cadena de texto)
- Apellido (cadena de texto)
- DNI (cadena de texto)

## Video Instructivo
https://youtu.be/NjX3HQ_DywQ

## Requerimientos
- Implementación de endpoints CRUD (Crear, Leer, Actualizar, Eliminar) para los usuarios.
- Uso de SQL Server, MySQL o MongoDB como base de datos.
- Inclusión de validaciones adecuadas para las propiedades de los usuarios.
- Estilo de la interfaz diseñado de acuerdo a una referencia específica utilizando CSS.
- Instrucciones claras sobre cómo configurar y ejecutar el proyecto en el archivo README.md.
- Capturas de pantalla o un video de la aplicación en funcionamiento.
# Instalación
### Requisitos
✅.NET Core SDK (versión 7.0 o superior).<br>
✅SQL Server, MySQL o MongoDB.
##3 Pasos para la Instalación<br>
`git clone https://github.com/ANG3L-GAMBOA/NetWayni.git`<br>
`cd tu_proyecto`
### Configuracion de la Base de Datos

### Crear Base de Datos
- Para evitar cualquier tipo de problema en la ejecución del proyecto recomendado crear la base de datos con el nombre de `pruebaE`
  
### UNO

- var server = Environment.GetEnvironmentVariable("Tu Servidor");
- var dbName = Environment.GetEnvironmentVariable("Nombre de Base de Datos");
- var dbUser = Environment.GetEnvironmentVariable("Nombre de Base de Datos, en caso no tener dejar solo `("root")`  en el caso de SQL Server `("master")`");
- var dbPassword = Environment.GetEnvironmentVariable("Contraseña de Base de Datos, en caso no tener dejar solo `("")`");

- var connectionString = $"Server={"Tu Servidor"};Database={"Nombre de Base de Datos"};User Id={"Nombre de Base de Datos, en caso no tener dejar solo `("")` "};Password={Contraseña de Base de Datos, en caso no tener dejar solo `("")`};TrustServerCertificate=True;";<br>
<br>
 └── 📂 Repositories │ └── 📂 Conexión │ └── 📂 Conexión.cs


### DOS

- DB_SERVER=Tu Servidor
- DB_NAME= Nombre de Base de Datos
- DB_USER=Nombre de Base de Datos, en caso no tener dejar solo `("")`
- DB_PASSWORD=Contraseña de Base de Datos, en caso no tener dejar solo `("")`<br>
<br>
  └── 📂 PruebaE │ └── 📂 .env

# Tecnologías Utilizadas
- [ASP.NET CORE](https://dotnet.microsoft.com/es-es/apps/aspnet)  MVC - Framework para el desarrollo de aplicaciones web.
- [Entity Framework Core](https://learn.microsoft.com/es-es/ef/core/) - ORM para la gestión de la base de datos.
- [SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-2019) - Sistemas de gestión de base de datos.
- [Clean Architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html) - Para asegurar una mejor separación de responsabilidades.
- [C#](https://learn.microsoft.com/es-es/dotnet/csharp/) - Lenguaje de programación.
- [HTML/CSS](https://www.w3schools.com/html/html_css.asp) - Para la interfaz de usuario.
- [GIT](https://git-scm.com/docs/git) - Para manejo de las versiones.

# Arquitectura
Este proyecto sigue los principios de Clean Architecture, que incluye:

Capa de Presentación (UI): Maneja la interacción con el usuario.
Capa de Aplicación: Contiene la lógica de la aplicación sin depender de los frameworks externos.
Capa de Dominio: Contiene las entidades y las reglas de negocio fundamentales.
Capa de Infraestructura: Maneja la interacción con la base de datos.

