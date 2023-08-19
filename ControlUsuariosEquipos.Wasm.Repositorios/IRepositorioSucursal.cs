using ControlUsuariosEquipos.Wasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Repositorios
{
    public interface IRepositorioSucursal
    {
        Task<IEnumerable<Sucursal>> ObtenerSucursalesPorAgencia(int idAgencia);
    }
}
