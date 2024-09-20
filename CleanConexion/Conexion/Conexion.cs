using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CleanConexion.Conexion
{
    public static class Conexion
    {
        public static void InyectionDependecy(this IServiceCollection services)
        {
            // Obtener las variables del archivo .env
            var server = Environment.GetEnvironmentVariable("DESKTOP-BKURH2Q");
            var dbName = Environment.GetEnvironmentVariable("pruebaE");
            var dbUser = Environment.GetEnvironmentVariable("sa");
            var dbPassword = Environment.GetEnvironmentVariable("123456");

            // Crear la cadena de conexión
            var connectionString = $"Server={"DESKTOP-BKURH2Q"};Database={"pruebaE"};User Id={"sa"};Password={123456};TrustServerCertificate=True;";

            // Configurar el DbContext
            services.AddDbContext<PruebaEContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            // Registrar servicios y repositorios
            //services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            //services.AddScoped<IUserServices, UserService>();
            //services.AddScoped<IDocumentTypeService, DocumentTypeService>();
            //services.AddScoped<IBuyerService, BuyerService>();
            //services.AddScoped<ISellerService, SellerService>();

            // Registrar AutoMapper
            //services.AddAutoMapper(typeof(AutoMapperProfile));
        }
    }
}
