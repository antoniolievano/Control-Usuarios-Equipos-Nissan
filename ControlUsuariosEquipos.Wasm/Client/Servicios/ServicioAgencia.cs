using ControlUsuariosEquipos.Wasm.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Client.Servicios
{
    public class ServicioAgencia : IServicioAgencia
    {
        private readonly HttpClient _httpClient;

        public ServicioAgencia(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //Función que implementa la información obtenida del controlador con directiva Agencia
        public async Task<IEnumerable<Agencia>> ObtenerAgencias()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Agencia>>($"api/Agencia");
        }
    }
}
