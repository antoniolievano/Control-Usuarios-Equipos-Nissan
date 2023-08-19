using ControlUsuariosEquipos.Wasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Repositorios
{
    public interface IRepositorioEquipo
    {
        Task<bool> InsertarEquipo(Equipo equipo);
        Task<bool> ActualizarEquipo(Equipo equipo);
        Task EliminarEquipo(int id);
        Task<int> SiguienteId();
        Task<IEnumerable<Equipo>> ObtenerEquipos();
        Task<Equipo> DetallesEquipo(int id);
        Task<int> CantidadEquipos();
        Task<int> CantidadEquiposLibres();
        Task<IEnumerable<string>> ObtenerFolios();
        Task<IEnumerable<Equipo>> ObtenerEquiposPorUsuario(int idUsuario);
        Task<IEnumerable<Equipo>> ObtenerEquiposSinUsuario();
        Task<int> CantidadEquiposPorUsuario(int idUsuario);
    }
}
