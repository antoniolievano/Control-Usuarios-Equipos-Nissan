using ControlUsuariosEquipos.Wasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Repositorios
{
    public interface IRepositorioPCHardware
    {
        Task<bool> InsertarPCHardware(int idEquipo, EquipoHardwareComputadora hardwareComputadora);
        Task<EquipoHardwareComputadora> ObtenerPCHardwarePorEquipo(int idEquipo);
        Task<bool> EliminarPCHardwarePorEquipo(int idEquipo);
        Task<bool> ActualizarPCHardware(EquipoHardwareComputadora hardwareComputadora);
    }
}
