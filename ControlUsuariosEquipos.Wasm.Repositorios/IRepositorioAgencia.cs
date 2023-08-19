using ControlUsuariosEquipos.Wasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Repositorios
{
    public interface IRepositorioAgencia
    {
        //Función para obtener todas las agencias
        Task<IEnumerable<Agencia>> ObtenerAgencias();
    }
}
