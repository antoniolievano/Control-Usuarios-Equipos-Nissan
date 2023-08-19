using ControlUsuariosEquipos.Wasm.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Client.Servicios
{
    public class ServicioEquipo : IServicioEquipo
    {
        private readonly HttpClient _httpClient;

        public ServicioEquipo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<int> CantidadEquipos()
        {
            return await _httpClient.GetFromJsonAsync<int>($"api/Equipo/Cantidad_Equipos");
        }

        public async Task<int> CantidadEquiposLibres()
        {
            return await _httpClient.GetFromJsonAsync<int>($"api/Equipo/Cantidad_Equipos_Libres");
        }

        public async Task<Equipo> DetallesEquipo(int id)
        {
            return await _httpClient.GetFromJsonAsync<Equipo>($"api/Equipo/{id}");
        }

        public async Task EliminarEquipo(int id)
        {
            await _httpClient.DeleteAsync($"api/Equipo/{id}");
        }

        public async Task GuardarEquipo(Equipo equipo)
        {
            if(equipo.Id == 0)
            {
                await _httpClient.PostAsJsonAsync<Equipo>($"api/Equipo/", equipo);
            }
            else
            {
                await _httpClient.PutAsJsonAsync<Equipo>($"api/Equipo/{equipo.Id}", equipo);
            }
        }

        public async Task<IEnumerable<Equipo>> ObtenerEquipos()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Equipo>>($"api/Equipo");
        }

        public async Task<IEnumerable<Equipo>> ObtenerEquiposSinUsuario()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Equipo>>($"api/Equipo/Equipos_Sin_Usuario");
        }

        public async Task<IEnumerable<string>> ObtenerFolios()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<string>>($"api/Equipo/Obtener_Folios");
        }

        public async Task<EquipoHardwareComputadora> ObtenerPCHardwarePorEquipo(int idEquipo)
        {
            return await _httpClient.GetFromJsonAsync<EquipoHardwareComputadora>($"api/Equipo/Obtener_Hardware_Computadora/{idEquipo}");
        }

        public async Task<EquipoSoftwareComputadora> ObtenerPCSoftwarePorEquipo(int idEquipo)
        {
            return await _httpClient.GetFromJsonAsync<EquipoSoftwareComputadora>($"api/Equipo/Obtener_Software_Computadora/{idEquipo}");
        }

        public async Task<IEnumerable<Usuario>> ObtenerUsuariosSimplificado()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Usuario>>($"api/Equipo/Obtener_Usuarios");
        }
    }
}
