using ControlUsuariosEquipos.Wasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Repositorios
{
    public interface IRepositorioUsuarioSiaChesa
    {
        Task<bool> InsertarUsuarioSiaChesa(int idUsuario, Usuario_Sia_Chesa usuarioChesa);
        Task<IEnumerable<Usuario_Sia_Chesa>> ObtenerUsuariosSiaChesaPorUsuario(int idUsuario);
        Task<bool> EliminarUsuariosSiaChesaPorUsuario(int idUsuario);
    }
}
