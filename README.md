# Gestión de Usuarios con .NET Core
## Descripción del Proyecto
Este proyecto es una solución desarrollada con .NET Core, estructurada en capas utilizando Clean Architecture y con una interfaz en MVC. La plataforma permite gestionar una lista de usuarios, donde cada usuario tiene las siguientes propiedades:

- Nombre (cadena de texto)
- Apellido (cadena de texto)
- DNI (cadena de texto)

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
##3 Pasos para la Instalación
`git clone https://github.com/ANG3L-GAMBOA/NetWayni.git`<br>
`cd tu_proyecto`
### Configuracion de la Base de Datos

### Crear Base de Datos
- Para evitar cualquier tipo de problema en la ejecución del proyecto recomendado crear la base de datos con el nombre de `pruebaE`
  
### UNO

- var server = Environment.GetEnvironmentVariable("Tu Servidor");
- var dbName = Environment.GetEnvironmentVariable("Nombre de Base de Datos");
- var dbUser = Environment.GetEnvironmentVariable("Nombre de Base de Datos, en caso no tener dejar solo `("")` ");
- var dbPassword = Environment.GetEnvironmentVariable("Contraseña de Base de Datos, en caso no tener dejar solo `("")`");

- var connectionString = $"Server={"Tu Servidor"};Database={"Nombre de Base de Datos"};User Id={"Nombre de Base de Datos, en caso no tener dejar solo `("")` "};Password={Contraseña de Base de Datos, en caso no tener dejar solo `("")`};TrustServerCertificate=True;";<br>

 └── 📂 Repositories │ └── 📂 Conexión │ └── 📂 Conexión.cs


### DOS

- DB_SERVER=Tu Servidor
- DB_NAME= Nombre de Base de Datos
- DB_USER=Nombre de Base de Datos, en caso no tener dejar solo `("")`
- DB_PASSWORD=Contraseña de Base de Datos, en caso no tener dejar solo `("")`<br>

  └── 📂 PruebaE │ └── 📂 .env


