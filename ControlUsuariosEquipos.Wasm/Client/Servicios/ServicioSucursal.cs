using ControlUsuariosEquipos.Wasm.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Client.Servicios
{
    public class ServicioSucursal : IServicioSucursal
    {
        private readonly HttpClient _httpClient;

        public ServicioSucursal(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Sucursal>> ObtenerSucursalesPorAgencia(int idAgencia)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Sucursal>>($"api/Sucursal/Obtener_Sucursales_Por_Agencia/{idAgencia}");
        }
    }
}
