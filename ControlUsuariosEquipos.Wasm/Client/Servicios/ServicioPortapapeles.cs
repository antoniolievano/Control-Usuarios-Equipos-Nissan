using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Client.Servicios
{
    public class ServicioPortapapeles : IServicioPortapapeles
    {
        private readonly IJSRuntime _jsInterop;
        public ServicioPortapapeles(IJSRuntime jsInterop)
        {
            _jsInterop = jsInterop;
        }
        public async Task CopyToClipboard(string text)
        {
            await _jsInterop.InvokeVoidAsync("navigator.clipboard.writeText", text);
        }
    }
}
