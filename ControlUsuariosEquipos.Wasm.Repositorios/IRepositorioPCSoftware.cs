using ControlUsuariosEquipos.Wasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Repositorios
{
    public interface IRepositorioPCSoftware
    {
        Task<bool> InsertarPCSoftware(int idEquipo, EquipoSoftwareComputadora softwareComputadora);
        Task<EquipoSoftwareComputadora> ObtenerPCSoftwarePorEquipo(int idEquipo);
        Task<bool> EliminarPCSoftwarePorEquipo(int idEquipo);
    }
}
