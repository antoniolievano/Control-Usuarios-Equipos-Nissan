using ControlUsuariosEquipos.Wasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Repositorios
{
    public interface IRepositorioUsuario
    {
        Task<bool> InsertarUsuario(Usuario usuario);
        Task<bool> ActualizarUsuario(Usuario usuario);
        Task EliminarUsuario(int id);
        Task<int> SiguienteId();
        Task<IEnumerable<Usuario>> ObtenerUsuarios();
        Task<Usuario> DetallesUsuario(int id);
        Task<IEnumerable<Usuario>> ObtenerUsuariosSimplificado();
        Task<int> CantidadUsuarios();
    }
}
