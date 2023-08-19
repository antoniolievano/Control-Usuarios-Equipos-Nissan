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
    public class UsuarioController : ControllerBase
    {
        private readonly IRepositorioUsuario _repositorioUsuario;
        private readonly IRepositorioEquipo _repositorioEquipo;
        private readonly IRepositorioUsuarioCorreos _repositorioUsuarioCorreos;
        private readonly IRepositorioUsuarioSiaChesa _repositorioUsuarioSiaChesa;
        private readonly IRepositorioUsuarioSiaRenault _repositorioUsuarioSiaRenault;

        public UsuarioController(IRepositorioUsuario repositorioUsuario, IRepositorioUsuarioCorreos repositorioUsuarioCorreos,
            IRepositorioUsuarioSiaChesa repositorioUsuarioSiaChesa, IRepositorioUsuarioSiaRenault repositorioUsuarioSiaRenault,
            IRepositorioEquipo repositorioEquipo)
        {
            _repositorioUsuario = repositorioUsuario;
            _repositorioUsuarioCorreos = repositorioUsuarioCorreos;
            _repositorioUsuarioSiaChesa = repositorioUsuarioSiaChesa;
            _repositorioUsuarioSiaRenault = repositorioUsuarioSiaRenault;
            _repositorioEquipo = repositorioEquipo;
        }

        [HttpGet("{id}")]
        public async Task<Usuario> DetallesUsuario(int id)
        {
            var usuario = await _repositorioUsuario.DetallesUsuario(id);

            var correos = await _repositorioUsuarioCorreos.ObtenerCorreosPorUsuario(id);

            var usuariosChesa = await _repositorioUsuarioSiaChesa.ObtenerUsuariosSiaChesaPorUsuario(id);

            var usuariosRenault = await _repositorioUsuarioSiaRenault.ObtenerUsuariosSiaRenaultPorUsuario(id);

            if (usuario != null)
            {
                usuario.Correos = (List<Usuario_Correos>)correos;
                usuario.UsuariosChesa = (List<Usuario_Sia_Chesa>)usuariosChesa;
                usuario.UsuariosRenault = (List<Usuario_Sia_Renault>)usuariosRenault;
            }

            return usuario;
        }

        [HttpGet]
        public async Task<IEnumerable<Usuario>> ObtenerUsuarios()
        {
            return await _repositorioUsuario.ObtenerUsuarios();
        }

        [HttpGet("Obtener_Equipos/{idUsuario}")]
        public async Task<IEnumerable<Equipo>> ObtenerEquiposPorUsuario(int idUsuario)
        {
            return await _repositorioEquipo.ObtenerEquiposPorUsuario(idUsuario);
        }

        [HttpGet("Cantidad_Usuarios")]
        public async Task<int> CantidadUsuarios()
        {
            return await _repositorioUsuario.CantidadUsuarios();
        }

        [HttpGet("Obtener_Correos/{idUsuario}")]
        public async Task<IEnumerable<Usuario_Correos>> ObtenerCorreosPorUsuario(int idUsuario)
        {
            return await _repositorioUsuarioCorreos.ObtenerCorreosPorUsuario(idUsuario);
        }

        [HttpGet("Obtener_Usuarios_Sia_Chesa/{idUsuario}")]
        public async Task<IEnumerable<Usuario_Sia_Chesa>> ObtenerUsuariosSiaChesaPorUsuario(int idUsuario)
        {
            return await _repositorioUsuarioSiaChesa.ObtenerUsuariosSiaChesaPorUsuario(idUsuario);
        }

        [HttpGet("Obtener_Usuarios_Sia_Renault/{idUsuario}")]
        public async Task<IEnumerable<Usuario_Sia_Renault>> ObtenerUsuariosSiaRenaultPorUsuario(int idUsuario)
        {
            return await _repositorioUsuarioSiaRenault.ObtenerUsuariosSiaRenaultPorUsuario(idUsuario);
        }

        [HttpGet("Cantidad_Equipos/{idUsuario}")]
        public async Task<int> CantidadEquiposPorUsuario(int idUsuario)
        {
            return await _repositorioEquipo.CantidadEquiposPorUsuario(idUsuario);
        }

        [HttpPost]
        public async Task<IActionResult> InsertarUsuario([FromBody] Usuario usuario)
        {
            // Validación para evitar fallos en el ingreso de datos
            // a la base de datos si la inserción de los mismo no pasa por el frontend
            if(usuario == null)
            {
                return BadRequest("El usuario ingresado tiene uno o varios parámetros sin valor");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            using(TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                // Mandar a traer el siguiente Id del maestro 'Usuario' que servirá
                // para completar cada una de las acciones de sus detalles
                usuario.Id = await _repositorioUsuario.SiguienteId();
                await _repositorioUsuario.InsertarUsuario(usuario);
                if(usuario.Correos != null && usuario.Correos.Any())
                {
                    foreach (var correo in usuario.Correos)
                    {
                        await _repositorioUsuarioCorreos.InsertarCorreo(usuario.Id, correo);
                    }
                }
                if (usuario.UsuariosChesa != null && usuario.UsuariosChesa.Any())
                {
                    foreach (var usuarioChesa in usuario.UsuariosChesa)
                    {

                        await _repositorioUsuarioSiaChesa.InsertarUsuarioSiaChesa(usuario.Id, usuarioChesa);
                    }
                }
                if (usuario.UsuariosRenault != null && usuario.UsuariosRenault.Any())
                {
                    foreach (var usuarioRenault in usuario.UsuariosRenault)
                    {
                        await _repositorioUsuarioSiaRenault.InsertarUsuarioSiaRenault(usuario.Id, usuarioRenault);
                    }
                }
                scope.Complete();
            }

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarUsuario(int id, [FromBody] Usuario usuario)
        {
            // Validaciones puestas en la API para evitar fallos en el ingreso de datos
            // a la base de datos si la inserción de los mismo no pasa por el frontend
            if (usuario == null)
            {
                return BadRequest("El usuario ingresado tiene uno o varios parámetros sin valor");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                await _repositorioUsuario.ActualizarUsuario(usuario);

                await _repositorioUsuarioCorreos.EliminarCorreosPorUsuario(usuario.Id);
                await _repositorioUsuarioSiaChesa.EliminarUsuariosSiaChesaPorUsuario(usuario.Id);
                await _repositorioUsuarioSiaRenault.EliminarUsuariosSiaRenaultPorUsuario(usuario.Id);

                if (usuario.Correos != null && usuario.Correos.Any())
                {
                    foreach (var correo in usuario.Correos)
                    {
                        await _repositorioUsuarioCorreos.InsertarCorreo(usuario.Id, correo);
                    }
                }
                if (usuario.UsuariosChesa != null && usuario.UsuariosChesa.Any())
                {
                    foreach (var usuarioChesa in usuario.UsuariosChesa)
                    {
                        await _repositorioUsuarioSiaChesa.InsertarUsuarioSiaChesa(usuario.Id, usuarioChesa);
                    }
                }
                if (usuario.UsuariosRenault != null && usuario.UsuariosRenault.Any())
                {
                    foreach (var usuarioRenault in usuario.UsuariosRenault)
                    {
                        await _repositorioUsuarioSiaRenault.InsertarUsuarioSiaRenault(usuario.Id, usuarioRenault);
                    }
                }
                scope.Complete();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task EliminarUsuario(int id)
        {
            await _repositorioUsuarioCorreos.EliminarCorreosPorUsuario(id);
            await _repositorioUsuarioSiaChesa.EliminarUsuariosSiaChesaPorUsuario(id);
            await _repositorioUsuarioSiaRenault.EliminarUsuariosSiaRenaultPorUsuario(id);
            await _repositorioUsuario.EliminarUsuario(id);
        }
    }
}
