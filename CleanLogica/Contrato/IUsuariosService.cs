using CleanModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLogica.Contrato
{
    public interface IUsuariosService
    {
        // Registrar Usuario
        Task<Usuario> CreateUser(Usuario model);
        

        // Obtener todos los usuarios
        Task<List<Usuario>> GetUserDtos();
        
        // Eliminar usuario
        Task<bool> DeleteUser(long userId);

        // Actualizar usuario
        Task<bool> UpdateUser(Usuario model);
    }
}
