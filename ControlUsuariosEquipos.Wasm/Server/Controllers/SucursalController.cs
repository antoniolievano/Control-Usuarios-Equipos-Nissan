using ControlUsuariosEquipos.Wasm.Repositorios;
using ControlUsuariosEquipos.Wasm.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SucursalController : ControllerBase
    {
        private readonly IRepositorioSucursal _repositorioSucursal;

        public SucursalController(IRepositorioSucursal repositorioSucursal)
        {
            _repositorioSucursal = repositorioSucursal;
        }

        // Se da un nombre en específico al método HttpGet el cual devolverá
        // las sucursales según su relación con a agencia elegida
        [HttpGet("Obtener_Sucursales_Por_Agencia/{idAgencia}")]
        public async Task<IEnumerable<Sucursal>> ObtenerSucursalesPorAgencia(int idAgencia)
        {
            return await _repositorioSucursal.ObtenerSucursalesPorAgencia(idAgencia);
        }

    }
}
