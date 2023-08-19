using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Client.Servicios
{
    public interface IServicioPortapapeles
    {
        Task CopyToClipboard(string text);
    }
}
