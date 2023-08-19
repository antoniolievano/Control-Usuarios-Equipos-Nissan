using ControlUsuariosEquipos.Wasm.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Client.Servicios
{
    public interface IServicioEquipo
    {
        Task GuardarEquipo(Equipo equipo);
        Task<IEnumerable<Equipo>> ObtenerEquipos();
        Task<IEnumerable<Usuario>> ObtenerUsuariosSimplificado();
        Task<IEnumerable<Equipo>> ObtenerEquiposSinUsuario();
        Task<EquipoHardwareComputadora> ObtenerPCHardwarePorEquipo(int idEquipo);
        Task<EquipoSoftwareComputadora> ObtenerPCSoftwarePorEquipo(int idEquipo);
        Task<Equipo> DetallesEquipo(int id);
        Task EliminarEquipo(int id);
        Task<int> CantidadEquipos();
        Task<int> CantidadEquiposLibres();
        Task<IEnumerable<string>> ObtenerFolios();
    }
}
