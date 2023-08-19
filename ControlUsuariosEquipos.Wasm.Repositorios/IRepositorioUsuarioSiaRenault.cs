using ControlUsuariosEquipos.Wasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Repositorios
{
    public interface IRepositorioUsuarioSiaRenault
    {
        Task<bool> InsertarUsuarioSiaRenault(int idUsuario, Usuario_Sia_Renault usuarioRenault);
        Task<IEnumerable<Usuario_Sia_Renault>> ObtenerUsuariosSiaRenaultPorUsuario(int idUsuario);
        Task<bool> EliminarUsuariosSiaRenaultPorUsuario(int idUsuario);
    }
}
