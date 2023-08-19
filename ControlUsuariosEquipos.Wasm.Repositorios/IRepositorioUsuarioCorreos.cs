using ControlUsuariosEquipos.Wasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Repositorios
{
    public interface IRepositorioUsuarioCorreos
    {
        Task<bool> InsertarCorreo(int idUsuario, Usuario_Correos correo);
        Task<IEnumerable<Usuario_Correos>> ObtenerCorreosPorUsuario(int idUsuario);
        Task<bool> EliminarCorreosPorUsuario(int idUsuario);
    }
}
