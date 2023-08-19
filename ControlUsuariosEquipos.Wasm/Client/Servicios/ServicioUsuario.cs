using ControlUsuariosEquipos.Wasm.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Client.Servicios
{
    public class ServicioUsuario : IServicioUsuario
    {
        private readonly HttpClient _httpClient;

        public ServicioUsuario(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<int> CantidadEquipos(int idUsuario)
        {
            return await _httpClient.GetFromJsonAsync<int>($"api/Usuario/Cantidad_Equipos/{idUsuario}");
        }

        public async Task<IEnumerable<Equipo>> ObtenerEquiposPorUsuario(int idUsuario)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Equipo>>($"api/Usuario/Obtener_Equipos/{idUsuario}");
        }

        public async Task<int> CantidadUsuarios()
        {
            return await _httpClient.GetFromJsonAsync<int>($"api/Usuario/Cantidad_Usuarios");
        }

        public async Task<Usuario> DetallesUsuario(int id)
        {
            return await _httpClient.GetFromJsonAsync<Usuario>($"api/Usuario/{id}");
        }

        public async Task EliminarUsuario(int id)
        {
            await _httpClient.DeleteAsync($"api/Usuario/{id}");
        }

        public async Task GuardarUsuario(Usuario usuario)
        {
            if(usuario.Id == 0)
            { // Insertar 'Insert'
              // Invocar al mètodo para la inserción de datos
                await _httpClient.PostAsJsonAsync<Usuario>($"api/Usuario/", usuario);
            }
            else
            { // Actualizar 'Update'
                await _httpClient.PutAsJsonAsync<Usuario>($"api/Usuario/{usuario.Id}", usuario);
            }
        }

        public async Task<IEnumerable<Usuario_Correos>> ObtenerCorreosPorUsuario(int idUsuario)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Usuario_Correos>>($"api/Usuario/Obtener_Correos/{idUsuario}");
        }

        public async Task<IEnumerable<Usuario>> ObtenerUsuarios()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Usuario>>($"api/Usuario");
        }

        public async Task<IEnumerable<Usuario_Sia_Chesa>> ObtenerUsuariosSiaChesaPorUsuario(int idUsuario)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Usuario_Sia_Chesa>>($"api/Usuario/Obtener_Usuarios_Sia_Chesa/{idUsuario}");
        }

        public async Task<IEnumerable<Usuario_Sia_Renault>> ObtenerUsuariosSiaRenaultPorUsuario(int idUsuario)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Usuario_Sia_Renault>>($"api/Usuario/Obtener_Usuarios_Sia_Renault/{idUsuario}");
        }
    }
}
