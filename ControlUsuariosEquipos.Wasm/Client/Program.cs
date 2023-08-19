using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MudBlazor.Services;
using ControlUsuariosEquipos.Wasm.Client.Servicios;

namespace ControlUsuariosEquipos.Wasm.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddMudServices();

            builder.Services.AddScoped<IServicioAgencia, ServicioAgencia>();
            builder.Services.AddScoped<IServicioEquipo, ServicioEquipo>();
            builder.Services.AddScoped<IServicioSucursal, ServicioSucursal>();
            builder.Services.AddScoped<IServicioUsuario, ServicioUsuario>();
            builder.Services.AddScoped<IServicioPortapapeles, ServicioPortapapeles>();

            await builder.Build().RunAsync();
        }
    }
}
