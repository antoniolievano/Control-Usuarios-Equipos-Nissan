using ControlUsuariosEquipos.Wasm.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Client.Servicios
{
    public interface IServicioSucursal
    {
        Task <IEnumerable<Sucursal>> ObtenerSucursalesPorAgencia(int idAgencia);
    }
}
