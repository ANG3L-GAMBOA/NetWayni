using CleanConexion.Conexion;
using CleanLogica.Contrato;
using CleanModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLogica.Servicios
{
    public class UsuariosService : IUsuariosService
    {
        private readonly PruebaEContext pruebaEContext;

        public UsuariosService(PruebaEContext pruebaEContext)
        {
            this.pruebaEContext = pruebaEContext;
        }

        public async Task<Usuario> CreateUser(Usuario model)
        {
            try
            {
                // Agregar usuario al contexto
                await pruebaEContext.Usuarios.AddAsync(model);

                // Guardar los cambios en la base de datos
                await pruebaEContext.SaveChangesAsync();

                return model;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear usuario: {ex.Message}");
            }
        }

        public async Task<bool> DeleteUser(long userId)
        {
            try
            {
                // Buscar el usuario en la base de datos
                var user = await pruebaEContext.Usuarios.FirstOrDefaultAsync(u => u.Id == userId);

                if (user == null)
                    throw new Exception("Usuario no encontrado");

                // Eliminar el usuario del contexto
                pruebaEContext.Usuarios.Remove(user);

                // Guardar los cambios en la base de datos
                await pruebaEContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el usuario: {ex.Message}");
            }
        }

        public async Task<List<Usuario>> GetUserDtos()
        {
            try
            {
                // Obtener la lista de usuarios de la base de datos
                return await pruebaEContext.Usuarios.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener la lista de usuarios: {ex.Message}");
            }
        }

        public async Task<bool> UpdateUser(Usuario model)
        {
            try
            {
                // Buscar el usuario en la base de datos
                var existingUser = await pruebaEContext.Usuarios.FirstOrDefaultAsync(u => u.Id == model.Id);

                if (existingUser == null)
                    throw new Exception("Usuario no encontrado");

                // Actualizar los datos del usuario
                existingUser.Nombre = model.Nombre;
                existingUser.Apellido = model.Apellido;
                existingUser.Dni = model.Dni;

                // Guardar los cambios en la base de datos
                pruebaEContext.Usuarios.Update(existingUser);
                await pruebaEContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar el usuario: {ex.Message}");
            }
        }
    }
}
