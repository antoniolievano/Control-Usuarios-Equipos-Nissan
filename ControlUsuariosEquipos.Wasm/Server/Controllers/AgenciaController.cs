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
    public class AgenciaController : ControllerBase
    {
        private readonly IRepositorioAgencia _repositorioAgencia;

        public AgenciaController(IRepositorioAgencia repositorioAgencia)
        {
            _repositorioAgencia = repositorioAgencia;
        }

        [HttpGet]
        public async Task<IEnumerable<Agencia>> ObtenerAgencias()
        {
            return await _repositorioAgencia.ObtenerAgencias();
        }
    }
}
