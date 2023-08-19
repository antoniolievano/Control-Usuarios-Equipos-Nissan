using ControlUsuariosEquipos.Wasm.Repositorios;
using ControlUsuariosEquipos.Wasm.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace ControlUsuariosEquipos.Wasm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase
    {
        private readonly IRepositorioEquipo _repositorioEquipo;
        private readonly IRepositorioPCHardware _repositorioPCHardware;
        private readonly IRepositorioPCSoftware _repositorioPCSoftware;
        private readonly IRepositorioUsuario _repositorioUsuario;

        public EquipoController(IRepositorioEquipo repositorioEquipo, IRepositorioPCHardware repositorioPCHardware,
            IRepositorioPCSoftware repositorioPCSoftware, IRepositorioUsuario repositorioUsuario)
        {
            _repositorioEquipo = repositorioEquipo;
            _repositorioUsuario = repositorioUsuario;
            _repositorioPCHardware = repositorioPCHardware;
            _repositorioPCSoftware = repositorioPCSoftware;
        }

        [HttpGet("{id}")]
        public async Task<Equipo> DetallesEquipo(int id)
        {
            var equipo = await _repositorioEquipo.DetallesEquipo(id);

            var hardware = await _repositorioPCHardware.ObtenerPCHardwarePorEquipo(id);

            var software = await _repositorioPCSoftware.ObtenerPCSoftwarePorEquipo(id);

            if (equipo != null)
            {
                equipo.HardwareComputadora = hardware;
                equipo.SoftwareComputadora = software;
            }

            return equipo;
        }

        [HttpGet]
        public async Task<IEnumerable<Equipo>> ObtenerEquipos()
        {
            return await _repositorioEquipo.ObtenerEquipos();
        }

        [HttpGet("Equipos_Sin_Usuario")]
        public async Task<IEnumerable<Equipo>> ObtenerEquiposSinUsuario()
        {
            return await _repositorioEquipo.ObtenerEquiposSinUsuario();
        }

        [HttpGet("Cantidad_Equipos")]
        public async Task<int> CantidadEquipos()
        {
            return await _repositorioEquipo.CantidadEquipos();
        }

        [HttpGet("Cantidad_Equipos_Libres")]
        public async Task<int> CantidadEquiposLibres()
        {
            return await _repositorioEquipo.CantidadEquiposLibres();
        }

        [HttpGet("Obtener_Hardware_Computadora/{idEquipo}")]
        public async Task<EquipoHardwareComputadora> ObtenerPCHardwarePorEquipo(int idEquipo)
        {
            return await _repositorioPCHardware.ObtenerPCHardwarePorEquipo(idEquipo);
        }

        [HttpGet("Obtener_Software_Computadora/{idEquipo}")]
        public async Task<EquipoSoftwareComputadora> ObtenerPCSoftwarePorEquipo(int idEquipo)
        {
            return await _repositorioPCSoftware.ObtenerPCSoftwarePorEquipo(idEquipo);
        }

        [HttpGet("Obtener_Usuarios")]
        public async Task<IEnumerable<Usuario>> ObtenerUsuariosSimplificado()
        {
            return await _repositorioUsuario.ObtenerUsuariosSimplificado();
        }

        [HttpGet("Obtener_Folios")]
        public async Task<IEnumerable<string>> ObtenerFolios()
        {
            return await _repositorioEquipo.ObtenerFolios();
        }

        [HttpPost]
        public async Task<IActionResult> InsertarEquipo([FromBody] Equipo equipo)
        {
            if (equipo == null)
            {
                return BadRequest("El equipo ingresado tiene uno o varios parámetros sin valor");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                equipo.Id = await _repositorioEquipo.SiguienteId();
                await _repositorioEquipo.InsertarEquipo(equipo);

                if (equipo.HardwareComputadora != null)
                {
                    await _repositorioPCHardware.InsertarPCHardware(equipo.Id, equipo.HardwareComputadora);
                }

                if (equipo.SoftwareComputadora != null)
                {
                    await _repositorioPCSoftware.InsertarPCSoftware(equipo.Id, equipo.SoftwareComputadora);
                }
                scope.Complete();
            }

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarEquipo(int id, [FromBody] Equipo equipo)
        {
            if (equipo == null)
            {
                return BadRequest("El equipo ingresado tiene uno o varios parámetros sin valor");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!equipo.estaEliminando)
            {
                using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    await _repositorioEquipo.ActualizarEquipo(equipo);

                    await _repositorioPCHardware.EliminarPCHardwarePorEquipo(equipo.Id);
                    await _repositorioPCSoftware.EliminarPCSoftwarePorEquipo(equipo.Id);

                    if (equipo.HardwareComputadora != null)
                    {
                        await _repositorioPCHardware.InsertarPCHardware(equipo.Id, equipo.HardwareComputadora);
                    }

                    if (equipo.SoftwareComputadora != null)
                    {
                        await _repositorioPCSoftware.InsertarPCSoftware(equipo.Id, equipo.SoftwareComputadora);
                    }
                    scope.Complete();
                }
            }
            else
            {
                await _repositorioEquipo.ActualizarEquipo(equipo);
            }
            

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task EliminarEquipo(int id)
        {
            await _repositorioPCHardware.EliminarPCHardwarePorEquipo(id);
            await _repositorioPCSoftware.EliminarPCSoftwarePorEquipo(id);
            await _repositorioEquipo.EliminarEquipo(id);
        }
    }
}
