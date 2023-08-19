using ControlUsuariosEquipos.Wasm.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Client.Servicios
{
    public interface IServicioUsuario
    {
        // La función llamará al 'Insert' o 'Update' según la petición
        Task GuardarUsuario(Usuario usuario);
        Task<IEnumerable<Usuario>> ObtenerUsuarios();
        Task<IEnumerable<Usuario_Correos>> ObtenerCorreosPorUsuario(int idUsuario);
        Task<IEnumerable<Usuario_Sia_Chesa>> ObtenerUsuariosSiaChesaPorUsuario(int idUsuario);
        Task<IEnumerable<Usuario_Sia_Renault>> ObtenerUsuariosSiaRenaultPorUsuario(int idUsuario);
        Task<Usuario> DetallesUsuario(int id);
        Task EliminarUsuario(int id);
        Task<int> CantidadEquipos(int idUsuario);
        Task<int> CantidadUsuarios();
        Task<IEnumerable<Equipo>> ObtenerEquiposPorUsuario(int idUsuario);
    }
}
